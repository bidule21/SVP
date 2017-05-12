using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVPMigrator
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SVP.SVPEntitiesContainer newContext = new SVP.SVPEntitiesContainer())
            {
                using (Old.svp_oldEntities1 oldContext = new Old.svp_oldEntities1())
                {
                    foreach(Old.profile oldProfile in oldContext.profiles)
                    {
                        SVP.Profile newProfile = new SVP.Profile();
                        newProfile.Name = oldProfile.name;
                        newProfile.Value = oldProfile.disagprofiles.FirstOrDefault().value;
                        newContext.Profiles.Add(newProfile);
                    }
                    newContext.SaveChanges();
                    foreach(Old.club oldClub in oldContext.clubs)
                    {
                        SVP.Club newClub = new SVP.Club();
                        newClub.Name = oldClub.name;
                        foreach(Old.member oldMember in oldClub.members)
                        {
                            SVP.Member newMember = new SVP.Member();
                            newMember.Firstname = oldMember.firstname;
                            newMember.Name = oldMember.name;
                            if (oldMember.birthday < new DateTime(2017, 1, 1))
                                newMember.Birthday = oldMember.birthday;
                            else
                                newMember.Birthday = null;
                            newMember.Shortname = oldMember.shortname;
                            foreach(Old.sequence oldSeq in oldMember.sequences)
                            {
                                SVP.Sequence newSeq = new SVP.Sequence();
                                newSeq.Profile = newContext.Profiles.FirstOrDefault(x => x.Name.Equals(oldSeq.profile.name));
                                newSeq.Date = oldSeq.date.Value;
                                foreach(Old.shot oldShot in oldSeq.shots)
                                {
                                    SVP.Shot newShot = new SVP.Shot();
                                    newShot.Angle = oldShot.angle;
                                    newShot.FactorValue = oldShot.factor_value;
                                    newShot.ShotNumber = (short)oldShot.shot_number;
                                    newShot.Valid = oldShot.valid;
                                    newShot.Value = oldShot.value;
                                    newSeq.Shots.Add(newShot);
                                }
                                newMember.Sequences.Add(newSeq);
                            }
                            newClub.Members.Add(newMember);
                        }
                        newContext.Clubs.Add(newClub);
                    }
                }
                newContext.SaveChanges();
            }
        }
    }
}
