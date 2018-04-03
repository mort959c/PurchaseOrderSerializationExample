using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PurchaseOrderSerializationExample
{
    // The XmlRoot attribute allows you to set an alternate name   
    // (PurchaseOrder) for the XML element and its namespace. By   
    // default, the XmlSerializer uses the class name. The attribute   
    // also allows you to set the XML namespace for the element. Lastly,  
    // the attribute sets the IsNullable property, which specifies whether   
    // the xsi:null attribute appears if the class instance is set to   
    // a null reference.  
    [XmlRoot("PurchaseOrder", Namespace="PurchaseOrders", IsNullable = false)]
    public class PurchaseOrder
    {
        public Address ShipTo;
        public string OrderDate;
        // The XmlArray attribute changes the XML element name  
        // from the default of "OrderedItems" to "Items".
        [XmlArray("Items")]
        public OrderedItem[] OrderedItems;
        public decimal SubTotal;
        public decimal ShipCost;
        public decimal TotalCost;
    }
}
