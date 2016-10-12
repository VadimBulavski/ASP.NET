using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPTask1
{
    public partial class WebFormProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_Init(object sender, EventArgs e)
        {
            ListBoxProduct.DataSource = GetProducts();
            ListBoxProduct.DataBind();
        }

        protected List<string> GetProducts()
        {
            List<string> products = new List<string>();
            for (int i = 0; i < 10; ++i)
            {
                products.Add(String.Format("Product {0}", i+1));
            }
            return products;
        }

        protected void ButtRemoveFromBasket_Click(object sender, EventArgs e)
        {
            RemoveElementFromBasket();
        }

        protected void ButtAddBasket_Click(object sender, EventArgs e)
        {
            AddElementToBasket();
        }

        protected void ButtAddBasketAll_Click(object sender, EventArgs e)
        {
            AddElementToBasket();
        }

        protected void ButtRemoveFromBasketAll_Click(object sender, EventArgs e)
        {
            RemoveElementFromBasket();
        }

        protected void AddElementToBasket()
        {
            for (int i = 0; i < ListBoxProduct.Items.Count; ++i)
            {
                if (ListBoxProduct.Items[i].Selected)
                {
                    ListBoxBasket.Items.Add(ListBoxProduct.Items[i]);
                    ListBoxProduct.Items.Remove(ListBoxProduct.Items[i]);
                    --i;
                }
            }   
        }

        protected void RemoveElementFromBasket()
        {
            for (int i = 0; i < ListBoxBasket.Items.Count; ++i)
            {
                if (ListBoxBasket.Items[i].Selected)
                {
                    ListBoxProduct.Items.Add(ListBoxBasket.Items[i]);
                    ListBoxBasket.Items.Remove(ListBoxBasket.Items[i]);
                    --i;
                }
            }   
        }
    }
}