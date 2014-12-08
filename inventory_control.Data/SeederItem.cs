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
    internal static class SeederItem
    {
        internal static void Seed(ApplicationDbContext db)
        {
            SupplierPart part;

            //part = db.SupplierParts.FirstOrDefault(sp => sp.SupplierPartName == "PARTNAME");
            //db.Items.AddOrUpdate(i => i.ItemName, new Item { ItemName = "" , Description = "", 
            //    BarCode = "", MaxQuantity = 1, MinQuantity = 1, QuantityInStock = 100, 
            //    QuantityPerPallet = 100, SupplierId = part.SupplierId, SupplierPartId = part.SupplierPartId});
            
            part = db.SupplierParts.FirstOrDefault(sp => sp.SupplierPartName == "Battery Pack");
            db.Items.AddOrUpdate(i => i.ItemName, new Item { 
                ItemName = "Battery Pack-S" , 
                Description = "85kwh microprocessor controlled, lithium-ion battery", 
                BarCode = "38873506688326", MaxQuantity = 10000, MinQuantity = 1000, QuantityInStock = 10000, 
                QuantityPerPallet = 100, SupplierId = part.SupplierId, SupplierPartId = part.SupplierPartId});

            part = db.SupplierParts.FirstOrDefault(sp => sp.SupplierPartName == "Motor");
            db.Items.AddOrUpdate(i => i.ItemName, new Item { 
                ItemName = "Motor-S" , 
                Description = "Three phase, four pole AC induction motor with copper rotor", 
                BarCode = "31832523432613", MaxQuantity = 10000, MinQuantity = 1000, QuantityInStock = 10000, 
                QuantityPerPallet = 12500, SupplierId = part.SupplierId, SupplierPartId = part.SupplierPartId});

            part = db.SupplierParts.FirstOrDefault(sp => sp.SupplierPartName == "Onboard Charger");
            db.Items.AddOrUpdate(i => i.ItemName, new Item
            {
                ItemName = "Onboard Charger-S",
                Description = "10 kW capable on-board charger with the following input compatibility: 85-265 V, 45-65 Hz, 1-40 A", 
                BarCode = "30307318424823", MaxQuantity = 10000, MinQuantity = 1000, QuantityInStock = 10000, 
                QuantityPerPallet = 15000, SupplierId = part.SupplierId, SupplierPartId = part.SupplierPartId});

            part = db.SupplierParts.FirstOrDefault(sp => sp.SupplierPartName == "Universal Connector");
            db.Items.AddOrUpdate(i => i.ItemName, new Item
            {
                ItemName = "Universal Connector-S",
                Description = "10 kW capable Universal Mobile Connector with 110 V, 240 V, and J1772 adapters", 
                BarCode = "58241949887604", MaxQuantity = 10000, MinQuantity = 1000, QuantityInStock = 10000, 
                QuantityPerPallet = 17000, SupplierId = part.SupplierId, SupplierPartId = part.SupplierPartId});

            part = db.SupplierParts.FirstOrDefault(sp => sp.SupplierPartName == "Class A Stamplings");
            db.Items.AddOrUpdate(i => i.ItemName, new Item
            {
                ItemName = "Class A Stamplings-S",
                Description = "Lightweight aluminum body reinforced with high strength, boron steel elements", 
                BarCode = "91032597819482", MaxQuantity = 20000, MinQuantity = 2000, QuantityInStock = 20000, 
                QuantityPerPallet = 5000, SupplierId = part.SupplierId, SupplierPartId = part.SupplierPartId});

            part = db.SupplierParts.FirstOrDefault(sp => sp.SupplierPartName == "Front Bumper Assembly");
            db.Items.AddOrUpdate(i => i.ItemName, new Item
            {
                ItemName = "Front Bumper Assembly-S",
                Description = "Lightweight aluminum body reinforced with high strength, boron steel elements", 
                BarCode = "59852272839472", MaxQuantity = 10000, MinQuantity = 1000, QuantityInStock = 10000, 
                QuantityPerPallet = 7500, SupplierId = part.SupplierId, SupplierPartId = part.SupplierPartId});

            part = db.SupplierParts.FirstOrDefault(sp => sp.SupplierPartName == "Side Door Hinges");
            db.Items.AddOrUpdate(i => i.ItemName, new Item
            {
                ItemName = "Side Door Hinges-S",
                Description = "All alluminum hinges 4 per car", 
                BarCode = "58589134178085", MaxQuantity = 40000, MinQuantity = 4000, QuantityInStock = 40000, 
                QuantityPerPallet = 20000, SupplierId = part.SupplierId, SupplierPartId = part.SupplierPartId});

            part = db.SupplierParts.FirstOrDefault(sp => sp.SupplierPartName == "Headliner");
            db.Items.AddOrUpdate(i => i.ItemName, new Item
            {
                ItemName = "Headliner-S",
                Description = "brushed suede molded one-piece interior roof covering", 
                BarCode = "96293914209405", MaxQuantity = 10000, MinQuantity = 1000, QuantityInStock = 10000, 
                QuantityPerPallet = 1000, SupplierId = part.SupplierId, SupplierPartId = part.SupplierPartId});

            part = db.SupplierParts.FirstOrDefault(sp => sp.SupplierPartName == "Front Grille Surround");
            db.Items.AddOrUpdate(i => i.ItemName, new Item
            {
                ItemName = "Front Grille Surround-S",
                Description = "Chrome strip surrounding front grille", 
                BarCode = "31800250410978", MaxQuantity = 10000, MinQuantity = 1000, QuantityInStock = 10000, 
                QuantityPerPallet = 1000, SupplierId = part.SupplierId, SupplierPartId = part.SupplierPartId});

            part = db.SupplierParts.FirstOrDefault(sp => sp.SupplierPartName == "Windshield Assembly");
            db.Items.AddOrUpdate(i => i.ItemName, new Item
            {
                ItemName = "Windshield Assembly-S",
                Description = "UV and infrared blocking safety glass windshield", 
                BarCode = "17384896854793", MaxQuantity = 10000, MinQuantity = 1000, QuantityInStock = 10000, 
                QuantityPerPallet = 1000, SupplierId = part.SupplierId, SupplierPartId = part.SupplierPartId});

            part = db.SupplierParts.FirstOrDefault(sp => sp.SupplierPartName == "Rear Roof Panel Glass");
            db.Items.AddOrUpdate(i => i.ItemName, new Item
            {
                ItemName = "Rear Roof Panel Glass-S",
                Description = "Solar absorbing, laminated safety glass rear window with defroster", 
                BarCode = "92934322461630", MaxQuantity = 10000, MinQuantity = 1000, QuantityInStock = 10000, 
                QuantityPerPallet = 1000, SupplierId = part.SupplierId, SupplierPartId = part.SupplierPartId});

            part = db.SupplierParts.FirstOrDefault(sp => sp.SupplierPartName == "Hood Gas Spring");
            db.Items.AddOrUpdate(i => i.ItemName, new Item
            {
                ItemName = "Hood Gas Spring-S",
                Description = "Hood Gas Spring for Model S", 
                BarCode = "78168551101827", MaxQuantity = 10000, MinQuantity = 1000, QuantityInStock = 10000, 
                QuantityPerPallet = 1000, SupplierId = part.SupplierId, SupplierPartId = part.SupplierPartId});

            part = db.SupplierParts.FirstOrDefault(sp => sp.SupplierPartName == "Liftgate Gas Spring");
            db.Items.AddOrUpdate(i => i.ItemName, new Item
            {
                ItemName = "Liftgate Gas Spring-S",
                Description = "Liftgate Gas Spring for Model S", 
                BarCode = "94186972800394", MaxQuantity = 10000, MinQuantity = 1000, QuantityInStock = 10000, 
                QuantityPerPallet = 1000, SupplierId = part.SupplierId, SupplierPartId = part.SupplierPartId});

            part = db.SupplierParts.FirstOrDefault(sp => sp.SupplierPartName == "Pillar Acoustic Baffle");
            db.Items.AddOrUpdate(i => i.ItemName, new Item
            {
                ItemName = "Pillar Acoustic Baffle-S",
                Description = "Pillar Acoustic Baffle for Model S", 
                BarCode = "20956139134869", MaxQuantity = 10000, MinQuantity = 1000, QuantityInStock = 10000, 
                QuantityPerPallet = 1000, SupplierId = part.SupplierId, SupplierPartId = part.SupplierPartId});

            part = db.SupplierParts.FirstOrDefault(sp => sp.SupplierPartName == "Trunk Acoustic Dampers");
            db.Items.AddOrUpdate(i => i.ItemName, new Item
            {
                ItemName = "Trunk Acoustic Dampers-S",
                Description = "Trunk Acoustic Dampers for Model S", 
                BarCode = "94822752330719", MaxQuantity = 10000, MinQuantity = 1000, QuantityInStock = 10000, 
                QuantityPerPallet = 1000, SupplierId = part.SupplierId, SupplierPartId = part.SupplierPartId});

            part = db.SupplierParts.FirstOrDefault(sp => sp.SupplierPartName == "Window Regulator");
            db.Items.AddOrUpdate(i => i.ItemName, new Item
            {
                ItemName = "Window Regulator-S",
                Description = "Window Regulator for Model S", 
                BarCode = "44087637344979", MaxQuantity = 10000, MinQuantity = 1000, QuantityInStock = 10000, 
                QuantityPerPallet = 1000, SupplierId = part.SupplierId, SupplierPartId = part.SupplierPartId});

            part = db.SupplierParts.FirstOrDefault(sp => sp.SupplierPartName == "Power Recliner");
            db.Items.AddOrUpdate(i => i.ItemName, new Item 
            {
                ItemName = "Power Recliner-S",
                Description = "Power Recliner for Model S", 
                BarCode = "58699966600000", MaxQuantity = 10000, MinQuantity = 1000, QuantityInStock = 10000, 
                QuantityPerPallet = 1000, SupplierId = part.SupplierId, SupplierPartId = part.SupplierPartId});

            part = db.SupplierParts.FirstOrDefault(sp => sp.SupplierPartName == "Exterior Mirrors");
            db.Items.AddOrUpdate(i => i.ItemName, new Item
            {
                ItemName = "Exterior Mirrors-S",
                Description = "Manual folding side mirrors", 
                BarCode = "63114458836541", MaxQuantity = 20000, MinQuantity = 2000, QuantityInStock = 20000, 
                QuantityPerPallet = 15000, SupplierId = part.SupplierId, SupplierPartId = part.SupplierPartId});

            part = db.SupplierParts.FirstOrDefault(sp => sp.SupplierPartName == "Brake Pedal Switch");
            db.Items.AddOrUpdate(i => i.ItemName, new Item
            {
                ItemName = "Brake Pedal Switch-S",
                Description = "Brake Pedal Switch for Model S", 
                BarCode = "92392736255359", MaxQuantity = 10000, MinQuantity = 1000, QuantityInStock = 10000, 
                QuantityPerPallet = 15000, SupplierId = part.SupplierId, SupplierPartId = part.SupplierPartId});

            part = db.SupplierParts.FirstOrDefault(sp => sp.SupplierPartName == "Brake Caliper");
            db.Items.AddOrUpdate(i => i.ItemName, new Item
            {
                ItemName = "Brake Caliper-S",
                Description = "Brake Caliper for Model S", 
                BarCode = "34062842260053", MaxQuantity = 20000, MinQuantity = 2000, QuantityInStock = 20000, 
                QuantityPerPallet = 17000, SupplierId = part.SupplierId, SupplierPartId = part.SupplierPartId});

            part = db.SupplierParts.FirstOrDefault(sp => sp.SupplierPartName == "Brake Disc");
            db.Items.AddOrUpdate(i => i.ItemName, new Item
            {
                ItemName = "Brake Disc-S",
                Description = "Brake Disc for Model S", 
                BarCode = "33644626381539", MaxQuantity = 20000, MinQuantity = 2000, QuantityInStock = 20000, 
                QuantityPerPallet = 22000, SupplierId = part.SupplierId, SupplierPartId = part.SupplierPartId});

            part = db.SupplierParts.FirstOrDefault(sp => sp.SupplierPartName == "Vacuum Brake Hose");
            db.Items.AddOrUpdate(i => i.ItemName, new Item
            {
                ItemName = "Vacuum Brake Hose-S",
                Description = "Vacuum Brake Hose for Model S", 
                BarCode = "32201132051174", MaxQuantity = 10000, MinQuantity = 1000, QuantityInStock = 10000, 
                QuantityPerPallet = 10000, SupplierId = part.SupplierId, SupplierPartId = part.SupplierPartId});
            
            db.SaveChanges();
        }

    }
}
