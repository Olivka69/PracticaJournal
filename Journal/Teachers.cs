//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Journal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Teachers
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string FirstName { get; set; }
        public Nullable<int> ClassId { get; set; }
    
        public virtual Class Class { get; set; }
    }
}
