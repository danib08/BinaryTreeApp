using System.Collections.Generic;
using Android.Content;
using Android.Views;
using Android.Widget;

namespace BinaryTreeApp
{
    /// <summary>
    /// This class is a custom adapter for the ListView containing the binary tree route.
    /// This adapter manages all of the iteration through its items in the backend.
    /// All of the methods are called and used by the adapter in the backend.
    /// It inherits from BaseAdapter.
    /// </summary>
    public class OrderAdapter : BaseAdapter<int> {
        private IList<int> items;
        private Context _context;
        
        /// <summary>
        /// Constructor for the adapter
        /// </summary>
        /// <param name="context"> The context in which the adapter will inflate </param>
        /// <param name="items"> The list of items to be displayed in the ListView </param>
        public OrderAdapter(Context context, IList<int> items) {
            _context = context;
            this.items = items;
        }
        
        /// <summary>
        /// This method returns the current position iterated by the adapter
        /// </summary>
        /// <param name="position"> The current position </param>
        /// <returns> The current position</returns>
        public override long GetItemId(int position)
        {
            return position;        
        }

        /// <summary>
        /// Gets the length of the list of items to be displayed
        /// </summary>
        public override int Count => items.Count;

        /// <summary>
        /// This property returns the item in the list positioned at the entered index
        /// </summary>
        /// <param name="position"> The desired index </param>
        public override int this[int position] => items[position];
        
        /// <summary>
        /// This method is in charge of inflating the rows of the ListView 
        /// </summary>
        /// <param name="position"> The current position </param>
        /// <param name="convertView"> The old view to reuse, if possible. </param>
        /// <param name="parent"> The parent that this view will eventually be attached to </param>
        /// <returns></returns>
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var row = convertView;

            if (row == null) {
                row = LayoutInflater.From(_context).Inflate(Resource.Layout.ListViewRow, null, false);
            }

            var followTxt = row.FindViewById<TextView>(Resource.Id.rowText);

            followTxt.Text = items[position].ToString();

            return row;
        }

        /// <summary>
        /// Setter property for the items attribute
        /// </summary>
        public IList<int> Items
        {
            set => items = value;
        }
    }
}