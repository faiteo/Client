using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class ProductTestWebPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            myHeader.Visible = false;
            panelProdInfo.Visible = false;

        }

        protected void btnFindProduct_Click(object sender, EventArgs e)
        {
            ServiceReference_Product.ProductServiceClient client = new ServiceReference_Product.ProductServiceClient("BasicHttpBinding_IProductService");
            int idInput;
            bool res;
            if (res = Int32.TryParse(txtBoxProdID.Text, out idInput))
            {
                ServiceReference_Product.Product prod = client.GetProduct(idInput);
                if (prod != null)
                {
                    if (prod.Type == ServiceReference_Product.Product.ProductType.Book)
                    {
                        myHeader.Visible = true;
                        panelProdInfo.Visible = true;

                        ServiceReference_Product.Book book = (ServiceReference_Product.Book)prod;
                        lblID.Text = book.Id.ToString();
                        lblTitle.Text = book.Title;
                        lblDescription.Text = book.Description;
                        lblType.Text = book.Type.ToString();
                        lblPrice.Text = book.Price.ToString() + " DKK";

                        Label lblAuthor = new Label();
                        lblAuthor.Font.Bold = true;
                        lblAuthor.Text = "Author Name: ";

                        panelProdInfo.Controls.Add(lblAuthor);

                        Label authorContent = new Label();
                        authorContent.Text = book.AuthorName;
                        panelProdInfo.Controls.Add(authorContent);
                    }
                    else
                    {
                        myHeader.Visible = true;
                        panelProdInfo.Visible = true;

                        ServiceReference_Product.CD cdObject = (ServiceReference_Product.CD)prod;
                        lblID.Text = cdObject.Id.ToString();
                        lblTitle.Text = cdObject.Title;
                        lblDescription.Text = cdObject.Description;
                        lblType.Text = cdObject.Type.ToString();
                        lblPrice.Text = cdObject.Price.ToString() + " DKK";

                        Label lblArtistName = new Label();
                        lblArtistName.Text = "Artist Name: ";
                        lblArtistName.Font.Bold = true;
                        panelProdInfo.Controls.Add(lblArtistName);

                        Label lblAtristNameContent = new Label();
                        lblAtristNameContent.Text = cdObject.ArtistName;
                        panelProdInfo.Controls.Add(lblAtristNameContent);

                        panelProdInfo.Controls.Add(new LiteralControl("<br />"));

                        Label lblNumOfTracks = new Label();
                        lblNumOfTracks.Font.Bold = true;
                        lblNumOfTracks.Text = "Number of Tracks: ";
                        panelProdInfo.Controls.Add(lblNumOfTracks);

                        Label lblnumOfTracksContent = new Label();
                        lblnumOfTracksContent.Text = cdObject.NumberOfTracks.ToString();
                        panelProdInfo.Controls.Add(lblnumOfTracksContent);
                    }
                }
                else
                {
                    lblError.Text = "Product IDs are 1,2,3,4,5,8,9,10,12 and 13";
                }
            }

            else
            {
                lblError.Text = "Error ! Valid product IDs are: 1,2,3,4,5,8,9,10,12 and 13";
            }
        }


    }
}