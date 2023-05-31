using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using WooCommerceNET.WooCommerce.v3;

namespace WooCommerceNET.WooCommerce.Extension
{
    [DataContract]
    public class Product : v3.Product
    {
        /// <summary>
        /// List of product bundle IDs that contain this product.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public List<int> bundled_by { get; set; }

        /// <summary>
        /// Forces all contents of this bundle to be treated as virtual.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool bundle_virtual { get; set; }

        /// <summary>
        /// Single-product details page layout. Applicable for bundle-type products only. Values: default, tabular.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string bundle_layout { get; set; }

        /// <summary>
        /// Controls the form location of the product in the single-product page. Applicable to bundle-type products.
        /// Values: default, after_summary
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string bundle_add_to_cart_form_location { get; set; }

        /// <summary>
        /// Controls whether the configuration of this product can be modified from the cart page. Applicable to bundle-type products.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool bundle_editable_in_cart { get; set; }

        /// <summary>
        /// Controls the display of bundle container/child items in cart/order templates. Applicable for bundle-type products only.
        /// Values: parent, noindent, none.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string bundle_item_grouping { get; set; }

        /// <summary>
        /// Min bundle size. Applicable for bundle-type products only.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int bundle_min_size { get; set; }

        /// <summary>
        /// Max bundle size. Applicable for bundle-type products only.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int bundle_max_size { get; set; }

        /// <summary>
        /// Stock status of this bundle, taking bundled product quantity requirements and limitations into account. Applicable for bundle-type products only. Read only.
        /// Values: instock, outofstock, insufficientstock.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string bundle_stock_status { get; set; }

        /// <summary>
        /// Quantity of bundles left in stock, taking bundled product quantity requirements into account. Applicable for bundle-type products only. Read only.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int bundle_stock_quantity { get; set; }

        /// <summary>
        /// List of bundled items contained in this product. See Bundled Item Properties.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public List<BundledItem> bundled_items { get; set; }

    }

    [DataContract]
    public class BundledItem
    {
        /// <summary>
        /// Bundled item ID.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int id { get; set; }

        /// <summary>
        /// Set to true to delete the bundled item with the specified ID.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool delete { get; set; }

        /// <summary>
        /// Bundled product ID.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int product_id { get; set; }

        /// <summary>
        /// Bundled item menu order.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int menu_order { get; set; }

        /// <summary>
        /// Minimum bundled item quantity.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string quantity_min { get; set; }

        /// <summary>
        /// Maximum bundled item quantity.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int quantity_max { get; set; }

        /// <summary>
        /// Indicates whether the price of this bundled item is added to the base price of the bundle.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool priced_individually { get; set; }

        /// <summary>
        /// Indicates whether the bundled product is shipped separately from the bundle.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool shipped_individually { get; set; }

        /// <summary>
        /// Indicates whether the title of the bundled product is overridden in front-end and e-mail templates.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool override_title { get; set; }

        /// <summary>
        /// Title of the bundled product to display instead of the original product title, if overridden.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string title { get; set; }

        /// <summary>
        /// Indicates whether the short description of the bundled product is overridden in front-end templates.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool override_description { get; set; }

        /// <summary>
        /// Short description of the bundled product to display instead of the original product short description, if overridden.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string description { get; set; }

        /// <summary>
        /// Indicates whether the bundled item is optional.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool optional { get; set; }

        /// <summary>
        /// Indicates whether the bundled product thumbnail is hidden in the single-product template.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool hide_thumbnail { get; set; }

        /// <summary>
        /// Discount applied to the bundled product, applicable when the Priced Individually option is enabled.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string discount { get; set; }

        /// <summary>
        /// Indicates whether variations filtering is active, applicable for variable bundled products only.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool override_variations { get; set; }

        /// <summary>
        /// List of enabled variation IDs, applicable when variations filtering is active
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public List<int> allowed_variations { get; set; }

        /// <summary>
        /// Indicates whether the default variation attribute values are overridden, applicable for variable bundled products only.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool override_default_variation_attributes { get; set; }

        /// <summary>
        /// Overridden default variation attribute values, if applicable.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public List<ProductDefaultAttribute> default_variation_attributes { get; set; }

        /// <summary>
        /// Indicates whether the bundled product is visible in the single-product template. Values: visible, hidden
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string single_product_visibility { get; set; }

        /// <summary>
        /// Indicates whether the bundled product is visible in cart templates. Values: visible, hidden.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string cart_visibility { get; set; }

        /// <summary>
        /// Indicates whether the bundled product is visible in order/e-mail templates. Values: visible, hidden.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string order_visibility { get; set; }

        /// <summary>
        /// Indicates whether the bundled product price is visible in the single-product template. Applicable when the Priced Individually option is enabled. Values: visible, hidden.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string single_product_price_visibility { get; set; }

        /// <summary>
        /// Indicates whether the bundled product price is visible in cart templates. Applicable when the Priced Individually option is enabled. Values: visible, hidden.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string cart_price_visibility { get; set; }

        /// <summary>
        /// Indicates whether the bundled product price is visible in order/e-mail templates. Applicable when the Priced Individually option is enabled. Values: visible, hidden.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string order_price_visibility { get; set; }

        /// <summary>
        /// Stock status of the bundled item, taking minimum quantity into account. Values: in_stock, on_backorder, out_of_stock.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool stock_status { get; set; }
    }
}
