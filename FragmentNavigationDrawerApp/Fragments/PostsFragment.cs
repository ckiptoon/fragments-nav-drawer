using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using V4Fragment = Android.Support.V4.App.Fragment;

namespace FragmentNavigationDrawerApp.Fragments
{
    public class PostsFragment : V4Fragment
    {
        public static PostsFragment NewInstance()
        {
            Bundle args = new Bundle();
            args.PutString("title", "Posts Fragment");

            PostsFragment fragment = new PostsFragment { Arguments = args };

            return fragment;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View view = inflater.Inflate(Resource.Layout.posts_fragment, container, false);

            TextView titleTextView = view.FindViewById<TextView>(Resource.Id.txt_posts_title);
            titleTextView.Text = Arguments.GetString("title");

            return view;
        }
    }
}