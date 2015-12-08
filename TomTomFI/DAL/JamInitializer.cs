using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TomTomFI.Models;

namespace TomTomFI.DAL
{
    public class JamInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<JamContext>
    {
        protected override void Seed(JamContext context)
        {
            var trajects = new List<Traject>
            {
            new Traject{ID=1,TrajectName="A1",JamDateTime=DateTime.Parse("2015-11-17")},
            new Traject{ID=2,TrajectName="A2",JamDateTime=DateTime.Parse("2015-11-17")},
            new Traject{ID=3,TrajectName="A10",JamDateTime=DateTime.Parse("2015-11-17")},
            new Traject{ID=4,TrajectName="A15",JamDateTime=DateTime.Parse("2015-11-17")},
            new Traject{ID=5,TrajectName="A4",JamDateTime=DateTime.Parse("2015-11-17")},
            new Traject{ID=6,TrajectName="A27",JamDateTime=DateTime.Parse("2015-11-17")},
            new Traject{ID=7,TrajectName="A7",JamDateTime=DateTime.Parse("2015-11-17")},
            new Traject{ID=8,TrajectName="A8",JamDateTime=DateTime.Parse("2015-11-17")}
            };

            trajects.ForEach(s => context.Trajects.Add(s));
            context.SaveChanges();

            var Regions = new List<Region>
            {
            new Region{RegionID=1,RegionName="Amsterdam",},
            new Region{RegionID=2,RegionName="Utrecht",},
            new Region{RegionID=3,RegionName="Denhaag",},
            new Region{RegionID=4,RegionName="Rotterdam",},
            new Region{RegionID=5,RegionName="Eindhoven",},
            new Region{RegionID=6,RegionName="Maastricht",},
            new Region{RegionID=7,RegionName="Groningen",}
            };
            Regions.ForEach(s => context.Regions.Add(s));
            context.SaveChanges();

            var jams = new List<Jam>
            {
            new Jam{TrajectID=1,RegionID=1,JamText="3 kilometer file tussen Amsterdam en Amersfort in bijde richtingen"},
            new Jam{TrajectID=1,RegionID=2,JamText="Bla een",},
            new Jam{TrajectID=1,RegionID=3,JamText="Bla een",},
            new Jam{TrajectID=2,RegionID=4,JamText="Bla een",},
            new Jam{TrajectID=2,RegionID=5,JamText="Bla een",},
            new Jam{TrajectID=2,RegionID=6,JamText="Bla een",},
            new Jam{TrajectID=3,RegionID=1},
//            new Jam{TrajectID=4,RegionID=1050,},
            new Jam{TrajectID=4,RegionID=2,JamText="Bla twee",},
            new Jam{TrajectID=5,RegionID=3,JamText="bla vier",},
            new Jam{TrajectID=6,RegionID=4},
            new Jam{TrajectID=7,RegionID=5,JamText="Bla vijf",},
            
            };
            jams.ForEach(s => context.Jams.Add(s));
            context.SaveChanges();
        }
    }
}
