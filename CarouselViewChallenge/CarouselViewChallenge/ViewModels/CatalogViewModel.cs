using CarouselViewChallenge.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CarouselViewChallenge.ViewModels
{
    public class CatalogViewModel
    {
        public IList<Item> Items { get; set; }

        public CatalogViewModel()
        {
            // create some dummy items
            Items = new ObservableCollection<Item>()
            {
                new Item ()
                {
                    Name="IKEA Chair",
                    Description="Bacon ipsum dolor amet bresaola shoulder cow, ham hock alcatra capicola strip steak fatback ground round venison rump turducken. Pastrami tail ground round, filet mignon rump pig shankle spare ribs cow hamburger short ribs turducken andouille. Chicken ground round pork, brisket ball tip kielbasa pancetta hamburger fatback ham hock meatloaf buffalo. Tenderloin ham hock pig swine brisket flank. Sausage doner beef leberkas, shank cupim pancetta buffalo fatback ribeye t-bone pork frankfurter pork chop ham hock. Picanha tri-tip brisket ground round meatloaf kielbasa short ribs drumstick kevin shankle. Sausage turducken landjaeger, frankfurter hamburger venison tongue kevin fatback andouille beef ribs chuck bacon alcatra prosciutto.",
                    InStock = true,
                    Image = "chair_yellow.png",
                    Price = 49.95M
                },
                new Item ()
                {
                    Name="Mammut",
                    Description="Bacon ipsum dolor amet bresaola shoulder cow, ham hock alcatra capicola strip steak fatback ground round venison rump turducken. Pastrami tail ground round, filet mignon rump pig shankle spare ribs cow hamburger short ribs turducken andouille. Chicken ground round pork, brisket ball tip kielbasa pancetta hamburger fatback ham hock meatloaf buffalo. Tenderloin ham hock pig swine brisket flank. Sausage doner beef leberkas, shank cupim pancetta buffalo fatback ribeye t-bone pork frankfurter pork chop ham hock. Picanha tri-tip brisket ground round meatloaf kielbasa short ribs drumstick kevin shankle. Sausage turducken landjaeger, frankfurter hamburger venison tongue kevin fatback andouille beef ribs chuck bacon alcatra prosciutto.",
                    InStock = true,
                    Image = "mammut_blue.png",
                    Price = 19.95M
                },
                new Item ()
                {
                    Name="Poang",
                    Description="Bacon ipsum dolor amet bresaola shoulder cow, ham hock alcatra capicola strip steak fatback ground round venison rump turducken. Pastrami tail ground round, filet mignon rump pig shankle spare ribs cow hamburger short ribs turducken andouille. Chicken ground round pork, brisket ball tip kielbasa pancetta hamburger fatback ham hock meatloaf buffalo. Tenderloin ham hock pig swine brisket flank. Sausage doner beef leberkas, shank cupim pancetta buffalo fatback ribeye t-bone pork frankfurter pork chop ham hock. Picanha tri-tip brisket ground round meatloaf kielbasa short ribs drumstick kevin shankle. Sausage turducken landjaeger, frankfurter hamburger venison tongue kevin fatback andouille beef ribs chuck bacon alcatra prosciutto.",
                    InStock = true,
                    Image = "poang_charcoal.png",
                    Price = 199.95M
                },
            };
        }
    }
}
