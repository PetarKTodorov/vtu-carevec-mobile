namespace CarevecMobile.Data.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Phone
    {
        public Phone()
        {
            this.UserMapping = new HashSet<PhoneUserMapping>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(6, MinimumLength = 2)]
        public string Model { get; set; }

        public string ImageUrl { get; set; }

        [Range(0, 5000)]
        public decimal Price { get; set; }

        public string Brand { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Year { get; set; }

        public string Description { get; set; }

        public ICollection<PhoneUserMapping> UserMapping { get; set; }

    }
}
