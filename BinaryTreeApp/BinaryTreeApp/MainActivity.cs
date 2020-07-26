using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;

namespace BinaryTreeApp
{
    /// <summary>
    /// This class is the main view of the app
    /// It inherits from the base class for Android activities
    /// </summary>
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity {
        private BinarySearchTree tree;
        private EditText numberEditText;
        private Button addBtn;
        private Button inorderBtn;
        private Button postorderBtn;
        private Button preorderBtn;
        private ListView orderListView;
        private IList<int> orderList;
        private OrderAdapter _adapter;
        
        /// <summary>
        /// This method is called when the activity is starting.
        /// It contains the logic for the binary tree display
        /// </summary>
        /// <param name="savedInstanceState"> a Bundle that contains the data the activity most recently
        /// supplied if the activity is being re-initialized after previously being shut down. </param>
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            
            tree = new BinarySearchTree();
            numberEditText = FindViewById<EditText>(Resource.Id.editText);
            addBtn = FindViewById<Button>(Resource.Id.button);
            preorderBtn = FindViewById<Button>(Resource.Id.button3);
            inorderBtn = FindViewById<Button>(Resource.Id.button4);
            postorderBtn = FindViewById<Button>(Resource.Id.button5);
            orderListView = FindViewById<ListView>(Resource.Id.listview);
            
            _adapter = new OrderAdapter(this, orderList);
            orderListView.Adapter = _adapter;
            
            addBtn.Click += (sender, args) =>
            {
                if (numberEditText.Text.Equals(""))
                {
                    var text = "Please write your desired number";
                    var toast = Toast.MakeText(this, text, ToastLength.Short);
                }
                else
                {
                    tree.insert(int.Parse(numberEditText.Text));
                }
            };
        }
    }
}