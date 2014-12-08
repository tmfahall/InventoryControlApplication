using inventory_control.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace inventory_control.Data
{
    internal static class SeederLocations
    {
        internal static void Seed(ApplicationDbContext db)
        {
                //       "1A01A" : 1 = BUILDING 1; A = ROW A; 01 = LOCATION 01; A = LEVEL A; 


                //NEW BUILDING 1
                //NEW ROW A
                //NEW LOCATION 1
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1A01A" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1A01B" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1A01C" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1A01D" });                                
                                
                //NEW LOCATION 
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1A02A" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1A02B" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1A02C" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1A02D" });
                                
                //NEW LOCATION 
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1A03A" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1A03B" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1A03C" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1A03D" });
                                
                //NEW LOCATION 
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1A04A" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1A04B" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1A04C" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1A04D" });
                                
                //NEW LOCATION 
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1A05A" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1A05B" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1A05C" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1A05D" });


                //NEW ROW B
                //NEW LOCATION 1
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1B01A" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1B01B" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1B01C" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1B01D" });

                //NEW LOCATION 
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1B02A" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1B02B" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1B02C" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1B02D" });

                //NEW LOCATION 
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1B03A" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1B03B" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1B03C" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1B03D" });

                //NEW LOCATION 
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1B04A" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1B04B" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1B04C" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1B04D" });

                //NEW LOCATION 
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1B05A" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1B05B" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1B05C" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1B05D" });


                //NEW ROW C
                //NEW LOCATION 1
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1C01A" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1C01B" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1C01C" });
                db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1C01D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1C02A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1C02B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1C02C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1C02D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1C03A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1C03B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1C03C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1C03D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1C04A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1C04B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1C04C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1C04D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1C05A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1C05B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1C05C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1C05D" });


                ////NEW ROW D
                ////NEW LOCATION 1
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1D01A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1D01B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1D01C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1D01D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1D02A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1D02B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1D02C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1D02D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1D03A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1D03B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1D03C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1D03D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1D04A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1D04B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1D04C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1D04D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1D05A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1D05B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1D05C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1D05D" });


                ////NEW ROW E
                ////NEW LOCATION 1
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1E01A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1E01B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1E01C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1E01D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1E02A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1E02B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1E02C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1E02D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1E03A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1E03B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1E03C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1E03D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1E04A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1E04B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1E04C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1E04D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1E05A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1E05B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1E05C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1E05D" });


                ////NEW ROW F
                ////NEW LOCATION 1
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1F01A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1F01B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1F01C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1F01D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1F02A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1F02B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1F02C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1F02D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1F03A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1F03B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1F03C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1F03D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1F04A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1F04B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1F04C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1F04D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1F05A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1F05B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1F05C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1F05D" });


                ////NEW ROW G
                ////NEW LOCATION 1
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1G01A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1G01B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1G01C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1G01D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1G02A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1G02B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1G02C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1G02D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1G03A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1G03B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1G03C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1G03D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1G04A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1G04B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1G04C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1G04D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1G05A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1G05B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1G05C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1G05D" });


                ////NEW ROW H
                ////NEW LOCATION 1
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1H01A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1H01B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1H01C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1H01D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1H02A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1H02B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1H02C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1H02D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1H03A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1H03B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1H03C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1H03D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1H04A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1H04B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1H04C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1H04D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1H05A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1H05B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1H05C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1H05D" });


                ////NEW ROW I
                ////NEW LOCATION 1
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1I01A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1I01B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1I01C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1I01D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1I02A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1I02B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1I02C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1I02D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1I03A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1I03B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1I03C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1I03D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1I04A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1I04B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1I04C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1I04D" });
                                                                                              
                ////NEW LOCATION                                                                
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1I05A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1I05B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1I05C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "1I05D" });




                ////NEW BUILDING 2
                ////NEW ROW A
                ////NEW LOCATION 1
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2A01A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2A01B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2A01C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2A01D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2A02A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2A02B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2A02C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2A02D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2A03A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2A03B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2A03C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2A03D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2A04A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2A04B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2A04C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2A04D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2A05A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2A05B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2A05C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2A05D" });
                                                                                             
                                                                                             
                ////NEW ROW B                                                                  
                ////NEW LOCATION 1                                                             
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2B01A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2B01B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2B01C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2B01D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2B02A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2B02B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2B02C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2B02D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2B03A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2B03B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2B03C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2B03D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2B04A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2B04B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2B04C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2B04D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2B05A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2B05B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2B05C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2B05D" });
                                                                                             
                                                                                             
                ////NEW ROW C                                                                  
                ////NEW LOCATION 1                                                             
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2C01A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2C01B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2C01C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2C01D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2C02A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2C02B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2C02C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2C02D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2C03A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2C03B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2C03C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2C03D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2C04A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2C04B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2C04C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2C04D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2C05A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2C05B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2C05C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2C05D" });
                                                                                             
                                                                                             
                ////NEW ROW D                                                                  
                ////NEW LOCATION 1                                                             
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2D01A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2D01B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2D01C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2D01D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2D02A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2D02B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2D02C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2D02D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2D03A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2D03B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2D03C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2D03D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2D04A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2D04B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2D04C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2D04D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2D05A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2D05B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2D05C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2D05D" });
                                                                                             
                                                                                             
                ////NEW ROW E                                                                  
                ////NEW LOCATION 1                                                             
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2E01A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2E01B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2E01C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2E01D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2E02A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2E02B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2E02C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2E02D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2E03A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2E03B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2E03C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2E03D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2E04A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2E04B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2E04C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2E04D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2E05A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2E05B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2E05C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2E05D" });
                                                                                             
                                                                                             
                ////NEW ROW F                                                                  
                ////NEW LOCATION 1                                                             
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2F01A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2F01B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2F01C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2F01D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2F02A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2F02B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2F02C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2F02D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2F03A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2F03B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2F03C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2F03D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2F04A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2F04B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2F04C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2F04D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2F05A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2F05B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2F05C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2F05D" });
                                                                                             
                                                                                             
                ////NEW ROW G                                                                  
                ////NEW LOCATION 1                                                             
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2G01A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2G01B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2G01C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2G01D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2G02A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2G02B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2G02C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2G02D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2G03A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2G03B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2G03C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2G03D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2G04A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2G04B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2G04C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2G04D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2G05A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2G05B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2G05C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2G05D" });
                                                                                             
                                                                                             
                ////NEW ROW H                                                                  
                ////NEW LOCATION 1                                                             
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2H01A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2H01B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2H01C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2H01D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2H02A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2H02B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2H02C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2H02D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2H03A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2H03B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2H03C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2H03D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2H04A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2H04B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2H04C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2H04D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2H05A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2H05B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2H05C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2H05D" });
                                                                                             
                                                                                             
                ////NEW ROW I                                                                  
                ////NEW LOCATION 1                                                             
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2I01A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2I01B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2I01C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2I01D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2I02A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2I02B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2I02C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2I02D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2I03A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2I03B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2I03C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2I03D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2I04A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2I04B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2I04C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2I04D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2I05A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2I05B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2I05C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "2I05D" });



                ////NEW BUILDING 3
                ////NEW ROW A
                ////NEW LOCATION 1
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3A01A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3A01B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3A01C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3A01D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3A02A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3A02B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3A02C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3A02D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3A03A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3A03B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3A03C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3A03D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3A04A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3A04B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3A04C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3A04D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3A05A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3A05B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3A05C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3A05D" });
                                                                                             
                                                                                             
                ////NEW ROW B                                                                  
                ////NEW LOCATION 1                                                             
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3B01A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3B01B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3B01C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3B01D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3B02A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3B02B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3B02C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3B02D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3B03A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3B03B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3B03C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3B03D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3B04A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3B04B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3B04C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3B04D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3B05A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3B05B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3B05C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3B05D" });
                                                                                             
                                                                                             
                ////NEW ROW C                                                                  
                ////NEW LOCATION 1                                                             
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3C01A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3C01B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3C01C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3C01D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3C02A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3C02B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3C02C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3C02D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3C03A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3C03B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3C03C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3C03D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3C04A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3C04B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3C04C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3C04D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3C05A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3C05B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3C05C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3C05D" });
                                                                                             
                                                                                             
                ////NEW ROW D                                                                  
                ////NEW LOCATION 1                                                             
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3D01A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3D01B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3D01C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3D01D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3D02A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3D02B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3D02C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3D02D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3D03A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3D03B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3D03C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3D03D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3D04A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3D04B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3D04C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3D04D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3D05A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3D05B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3D05C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3D05D" });
                                                                                             
                                                                                             
                ////NEW ROW E                                                                  
                ////NEW LOCATION 1                                                             
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3E01A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3E01B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3E01C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3E01D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3E02A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3E02B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3E02C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3E02D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3E03A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3E03B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3E03C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3E03D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3E04A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3E04B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3E04C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3E04D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3E05A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3E05B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3E05C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3E05D" });
                                                                                             
                                                                                             
                ////NEW ROW F                                                                  
                ////NEW LOCATION 1                                                             
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3F01A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3F01B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3F01C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3F01D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3F02A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3F02B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3F02C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3F02D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3F03A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3F03B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3F03C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3F03D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3F04A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3F04B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3F04C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3F04D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3F05A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3F05B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3F05C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3F05D" });
                                                                                             
                                                                                             
                ////NEW ROW G                                                                  
                ////NEW LOCATION 1                                                             
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3G01A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3G01B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3G01C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3G01D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3G02A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3G02B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3G02C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3G02D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3G03A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3G03B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3G03C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3G03D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3G04A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3G04B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3G04C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3G04D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3G05A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3G05B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3G05C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3G05D" });
                                                                                             
                                                                                             
                ////NEW ROW H                                                                  
                ////NEW LOCATION 1                                                             
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3H01A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3H01B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3H01C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3H01D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3H02A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3H02B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3H02C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3H02D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3H03A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3H03B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3H03C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3H03D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3H04A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3H04B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3H04C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3H04D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3H05A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3H05B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3H05C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3H05D" });
                                                                                             
                                                                                             
                ////NEW ROW I                                                                  
                ////NEW LOCATION 1                                                             
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3I01A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3I01B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3I01C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3I01D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3I02A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3I02B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3I02C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3I02D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3I03A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3I03B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3I03C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3I03D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3I04A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3I04B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3I04C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3I04D" });
                                                                                             
                ////NEW LOCATION                                                               
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3I05A" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3I05B" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3I05C" });
                //db.Locations.AddOrUpdate(l => l.LocationName, new Location {PalletCapacity = 3,  LocationName = "3I05D" });
            db.SaveChanges();
        }

    }
}
