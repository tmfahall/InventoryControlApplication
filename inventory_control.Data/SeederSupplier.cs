using inventory_control.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_control.Data
{
    internal static class SeederSupplier
    {
        internal static void Seed(ApplicationDbContext db)
        {
            Supplier supplier1;
            
            supplier1 = db.Suppliers.FirstOrDefault(s => s.SupplierName == "Tesla Motors");

            if (supplier1 == null)
            {
                db.Suppliers.Add(new Supplier
                {
                    SupplierName = "Tesla Motors"
                });

                db.SaveChanges();
                supplier1 = db.Suppliers.FirstOrDefault(s => s.SupplierName == "Tesla Motors");

                db.SupplierParts.Add(new SupplierPart
                {
                    SupplierPartName = "Battery Pack",
                    SupplierId = supplier1.SupplierId 
                });

                db.SupplierParts.Add(new SupplierPart
                {
                    SupplierPartName = "Motor",
                    SupplierId = supplier1.SupplierId
                });

                db.SupplierParts.Add(new SupplierPart
                {
                    SupplierPartName = "Onboard Charger",
                    SupplierId = supplier1.SupplierId
                });

                db.SupplierParts.Add(new SupplierPart
                {
                    SupplierPartName = "Universal Connector",
                    SupplierId = supplier1.SupplierId
                });

                db.SupplierParts.Add(new SupplierPart
                {
                    SupplierPartName = "Class A Stamplings",
                    SupplierId = supplier1.SupplierId
                });

                db.SaveChanges();
            }

            supplier1 = db.Suppliers.FirstOrDefault(s => s.SupplierName == "Multimatic");

            if (supplier1 == null)
            {
                db.Suppliers.Add(new Supplier
                {
                    SupplierName = "Multimatic"
                });

                db.SaveChanges();
                supplier1 = db.Suppliers.FirstOrDefault(s => s.SupplierName == "Multimatic");

                db.SupplierParts.Add(new SupplierPart
                {
                    SupplierPartName = "Front Bumper Assembly",
                    SupplierId = supplier1.SupplierId
                });

                db.SupplierParts.Add(new SupplierPart
                {
                    SupplierPartName = "Side Door Hinges",
                    SupplierId = supplier1.SupplierId
                });

                db.SaveChanges();
            }

            supplier1 = db.Suppliers.FirstOrDefault(s => s.SupplierName == "Magna");

            if (supplier1 == null)
            {
                db.Suppliers.Add(new Supplier
                {
                    SupplierName = "Magna"
                });

                db.SaveChanges();
                supplier1 = db.Suppliers.FirstOrDefault(s => s.SupplierName == "Magna");

                db.SupplierParts.Add(new SupplierPart
                {
                    SupplierPartName = "Headliner",
                    SupplierId = supplier1.SupplierId
                });

                db.SupplierParts.Add(new SupplierPart
                {
                    SupplierPartName = "Front Grille Surround",
                    SupplierId = supplier1.SupplierId
                });

                db.SaveChanges();
            }

            supplier1 = db.Suppliers.FirstOrDefault(s => s.SupplierName == "AGC Automotive");

            if (supplier1 == null)
            {
                db.Suppliers.Add(new Supplier
                {
                    SupplierName = "AGC Automotive"
                });

                db.SaveChanges();
                supplier1 = db.Suppliers.FirstOrDefault(s => s.SupplierName == "AGC Automotive");

                db.SupplierParts.Add(new SupplierPart
                {
                    SupplierPartName = "Windshield Assembly",
                    SupplierId = supplier1.SupplierId
                });

                db.SupplierParts.Add(new SupplierPart
                {
                    SupplierPartName = "Rear Roof Panel Glass",
                    SupplierId = supplier1.SupplierId
                });

                db.SaveChanges();
            }

            supplier1 = db.Suppliers.FirstOrDefault(s => s.SupplierName == "Stabilus");

            if (supplier1 == null)
            {
                db.Suppliers.Add(new Supplier
                {
                    SupplierName = "Stabilus"
                });

                db.SaveChanges();
                supplier1 = db.Suppliers.FirstOrDefault(s => s.SupplierName == "Stabilus");

                db.SupplierParts.Add(new SupplierPart
                {
                    SupplierPartName = "Hood Gas Spring",
                    SupplierId = supplier1.SupplierId
                });

                db.SupplierParts.Add(new SupplierPart
                {
                    SupplierPartName = "Liftgate Gas Spring",
                    SupplierId = supplier1.SupplierId
                });

                db.SaveChanges();
            }

            supplier1 = db.Suppliers.FirstOrDefault(s => s.SupplierName == "Sika");

            if (supplier1 == null)
            {
                db.Suppliers.Add(new Supplier
                {
                    SupplierName = "Sika"
                });

                db.SaveChanges();
                supplier1 = db.Suppliers.FirstOrDefault(s => s.SupplierName == "Sika");

                db.SupplierParts.Add(new SupplierPart
                {
                    SupplierPartName = "Pillar Acoustic Baffle",
                    SupplierId = supplier1.SupplierId
                });

                db.SupplierParts.Add(new SupplierPart
                {
                    SupplierPartName = "Trunk Acoustic Dampers",
                    SupplierId = supplier1.SupplierId
                });

                db.SaveChanges();
            }

            supplier1 = db.Suppliers.FirstOrDefault(s => s.SupplierName == "Inteva Products");

            if (supplier1 == null)
            {
                db.Suppliers.Add(new Supplier
                {
                    SupplierName = "Inteva Products"
                });

                db.SaveChanges();
                supplier1 = db.Suppliers.FirstOrDefault(s => s.SupplierName == "Inteva Products");

                db.SupplierParts.Add(new SupplierPart
                {
                    SupplierPartName = "Window Regulator",
                    SupplierId = supplier1.SupplierId
                });

                db.SupplierParts.Add(new SupplierPart
                {
                    SupplierPartName = "Power Recliner",
                    SupplierId = supplier1.SupplierId
                });

                db.SupplierParts.Add(new SupplierPart
                {
                    SupplierPartName = "Exterior Mirrors",
                    SupplierId = supplier1.SupplierId
                });

                db.SupplierParts.Add(new SupplierPart
                {
                    SupplierPartName = "Brake Pedal Switch",
                    SupplierId = supplier1.SupplierId
                });

                db.SupplierParts.Add(new SupplierPart
                {
                    SupplierPartName = "Brake Caliper",
                    SupplierId = supplier1.SupplierId
                });

                db.SupplierParts.Add(new SupplierPart
                {
                    SupplierPartName = "Brake Disc",
                    SupplierId = supplier1.SupplierId
                });

                db.SupplierParts.Add(new SupplierPart
                {
                    SupplierPartName = "Vacuum Brake Hose",
                    SupplierId = supplier1.SupplierId
                });

                db.SaveChanges();
            }

        }
    }
}
