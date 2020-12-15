using System;
using System.Collections.Generic;

namespace VendorService.Models
{
    public class Vendors
    {
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public string MaterialCategoryVendor { get; set; }

    }


    public class VendorsDb : List<Vendors>
    {
        public VendorsDb()
        {
            Add(new Vendors() { VendorId = 1001, VendorName = "MS-Electronics", MaterialCategoryVendor = "Electronics"});
            Add(new Vendors() { VendorId = 1002, VendorName = "LS-Electronics", MaterialCategoryVendor = "Electronics" });
            Add(new Vendors() { VendorId = 1003, VendorName = "TS-Electronics", MaterialCategoryVendor = "Electronics" });
            Add(new Vendors() { VendorId = 1004, VendorName = "MS-Electrical", MaterialCategoryVendor = "Electrical" });
            Add(new Vendors() { VendorId = 1005, VendorName = "LS-Electrical", MaterialCategoryVendor = "Electrical" });
            Add(new Vendors() { VendorId = 1006, VendorName = "TS-Electrical", MaterialCategoryVendor = "Electrical" });
            Add(new Vendors() { VendorId = 1007, VendorName = "MS-Food", MaterialCategoryVendor = "Food" });
            Add(new Vendors() { VendorId = 1008, VendorName = "LS-Food", MaterialCategoryVendor = "Food" });
            Add(new Vendors() { VendorId = 1009, VendorName = "TS-Food", MaterialCategoryVendor = "Food" });
            
        }
    }
}
