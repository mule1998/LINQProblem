using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LINQ_Project
{
    class Management
    {
        class Management
        {
            public readonly DataTable dataTable = new DataTable();
            public void TopRecords(List<ProductReview> listProductReview)
            {
                var recordData = (from productReviews in listProductReview
                                  orderby productReviews.Rating descending
                                  select productReviews).Take(3);




                foreach (var list in recordData)
                {
                    Console.WriteLine("ProductID:-" + list.ProductId + " " + "UserID:" + list.UserID +
                        " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " +
                        "People liked:-" + list.isLike);
                }
            }
        }
    }
}
