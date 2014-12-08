using inventory_control.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_control.Data
{
    internal static class SeederItemLocation
    {
        internal static void Seed(ApplicationDbContext db)
        {
            
            Location[] locations = db.Locations.ToArray();
            Item[] items = db.Items.ToArray();
            int loc = 0;

            //clear the current xref data
            db.ItemLocationXrefs.RemoveRange(db.ItemLocationXrefs.ToList());
            db.SaveChanges();

            //add new xref data
            if (locations.Length >= loc + 1 && items.Length >= 1)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[0].ItemId, QuantityOnPallet = items[0].QuantityPerPallet });
            if (locations.Length >= loc + 1 && items.Length >= 2)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[1].ItemId, QuantityOnPallet = items[1].QuantityPerPallet });
            if (locations.Length >= loc + 1 && items.Length >= 3)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[2].ItemId, QuantityOnPallet = items[2].QuantityPerPallet });

            loc++;

            if (locations.Length >= loc + 1 && items.Length >= 1)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[0].ItemId, QuantityOnPallet = items[0].QuantityPerPallet / 2});
            if (locations.Length >= loc + 1 && items.Length >= 2)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[1].ItemId, QuantityOnPallet = items[1].QuantityPerPallet / 2 });
            if (locations.Length >= loc + 1 && items.Length >= 3)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[2].ItemId, QuantityOnPallet = items[2].QuantityPerPallet / 2 });

            loc++;


            if (locations.Length >= loc + 1 && items.Length >= 6)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[4].ItemId, QuantityOnPallet = items[5].QuantityPerPallet });
                
            if (locations.Length >= loc + 1 && items.Length >= 7)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[5].ItemId, QuantityOnPallet = items[6].QuantityPerPallet });
                
            loc++;

            if (locations.Length >= loc + 1 && items.Length >= 6)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[5].ItemId, QuantityOnPallet = items[5].QuantityPerPallet / 2});

            if (locations.Length >= loc + 1 && items.Length >= 7)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[6].ItemId, QuantityOnPallet = items[6].QuantityPerPallet / 2});

            loc++;

            if (locations.Length >= loc + 1 && items.Length >= 8)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[7].ItemId, QuantityOnPallet = items[7].QuantityPerPallet });
                
            loc++;

            if (locations.Length >= loc + 1 && items.Length >= 8)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[7].ItemId, QuantityOnPallet = items[7].QuantityPerPallet / 2});

            loc++;

            if (locations.Length >= loc + 1 && items.Length >= 9)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[8].ItemId, QuantityOnPallet = items[8].QuantityPerPallet });
            if (locations.Length >= loc + 1 && items.Length >= 10)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[9].ItemId, QuantityOnPallet = items[9].QuantityPerPallet });

            loc++;

            if (locations.Length >= loc + 1 && items.Length >= 9)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[8].ItemId, QuantityOnPallet = items[8].QuantityPerPallet / 2});
            if (locations.Length >= loc + 1 && items.Length >= 10)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[9].ItemId, QuantityOnPallet = items[9].QuantityPerPallet  / 2});

            loc++;

            if (locations.Length >= loc + 1 && items.Length >= 11)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[10].ItemId, QuantityOnPallet = items[10].QuantityPerPallet });
            if (locations.Length >= loc + 1 && items.Length >= 11)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[10].ItemId, QuantityOnPallet = items[10].QuantityPerPallet });

            loc++;

            if (locations.Length >= loc + 1 && items.Length >= 11)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[10].ItemId, QuantityOnPallet = items[10].QuantityPerPallet / 2});
            if (locations.Length >= loc + 1 && items.Length >= 11)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[10].ItemId, QuantityOnPallet = items[10].QuantityPerPallet / 2});

            loc++;

            if (locations.Length >= loc + 1 && items.Length >= 12)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[11].ItemId, QuantityOnPallet = items[11].QuantityPerPallet });
            if (locations.Length >= loc + 1 && items.Length >= 13)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[11].ItemId, QuantityOnPallet = items[12].QuantityPerPallet });

            loc++;


            if (locations.Length >= loc + 1 && items.Length >= 12)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[12].ItemId, QuantityOnPallet = items[12].QuantityPerPallet });

            loc++;

            if (locations.Length >= loc + 1 && items.Length >= 4)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[3].ItemId, QuantityOnPallet = items[3].QuantityPerPallet });
            if (locations.Length >= loc + 1 && items.Length >= 5)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[4].ItemId, QuantityOnPallet = items[4].QuantityPerPallet });
            
            loc++;

            if (locations.Length >= loc + 1 && items.Length >= 14)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[13].ItemId, QuantityOnPallet = items[13].QuantityPerPallet });
            if (locations.Length >= loc + 1 && items.Length >= 15)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[14].ItemId, QuantityOnPallet = items[14].QuantityPerPallet });

            loc++;

            if (locations.Length >= loc + 1 && items.Length >= 16)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[15].ItemId, QuantityOnPallet = items[15].QuantityPerPallet });
            if (locations.Length >= loc + 1 && items.Length >= 17)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[16].ItemId, QuantityOnPallet = items[16].QuantityPerPallet });

            loc++;

            if (locations.Length >= loc + 1 && items.Length >= 18)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[17].ItemId, QuantityOnPallet = items[17].QuantityPerPallet });
            if (locations.Length >= loc + 1 && items.Length >= 19)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[18].ItemId, QuantityOnPallet = items[18].QuantityPerPallet });

            loc++;

            if (locations.Length >= loc + 1 && items.Length >= 20)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[19].ItemId, QuantityOnPallet = items[19].QuantityPerPallet });
            if (locations.Length >= loc + 1 && items.Length >= 21)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[20].ItemId, QuantityOnPallet = items[20].QuantityPerPallet });


            loc++;

            if (locations.Length >= loc + 1 && items.Length >= 21)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[20].ItemId, QuantityOnPallet = items[20].QuantityPerPallet });
            if (locations.Length >= loc + 1 && items.Length >= 22)
                db.ItemLocationXrefs.Add(new ItemLocationXref { LocationId = locations[loc].LocationId, ItemId = items[21].ItemId, QuantityOnPallet = items[21].QuantityPerPallet });

            db.SaveChanges();

            foreach (Item item in db.Items)
            {
                UpdateItemTotalQuantity(item.ItemId);
            }

        }

        internal static void UpdateItemTotalQuantity(int itemId)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Item dbItem = db.Items.FirstOrDefault(i => i.ItemId == itemId);

                if (dbItem != null)
                {
                    List<ItemLocationXref> items = db.ItemLocationXrefs.Where(i => i.ItemId == itemId).ToList();

                    int count = 0;

                    foreach (var item in items)
                    {
                        count += item.QuantityOnPallet;
                    }

                    dbItem.QuantityInStock = count;

                    db.SaveChanges();
                }
            }
        }
    }
}
