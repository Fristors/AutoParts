
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace AutoParts
{

using System;
    using System.Collections.Generic;
    
public partial class AutoPart
{

    public int id { get; set; }

    public string name { get; set; }

    public decimal Price;
    public decimal price 
    {
        get { return Price; }
        set { Price = Math.Round(value, 2); }
    }

    public int idCar { get; set; }

    public int idManufacturer { get; set; }

    public string description { get; set; }

    public string url { get; set; }



    public virtual Car Car { get; set; }

    public virtual Manufacturer Manufacturer { get; set; }

}

}
