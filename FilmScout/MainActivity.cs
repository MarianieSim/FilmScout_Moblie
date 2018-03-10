using Android.App;
using Android.Widget;
using Android.OS;

namespace FilmScout
{
    //MainLauncher = true
    [Activity(Label = "FilmScout", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        private EditText RName, REmail, RPass, RPass2, RFName, RLName, LEmail, LPass, Think, Star, Dir;
        private TextView UName, StartY, EndY;
        private SeekBar SYS, EYS;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
           
          

            // Set our view from the "main" layout resource

            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button Home = FindViewById<Button>(Resource.Id.HomeB);
            Button Regi = FindViewById<Button>(Resource.Id.RegB);
            Button Logi = FindViewById<Button>(Resource.Id.LoginB);
            Button SearchP = FindViewById<Button>(Resource.Id.Movie);

            Home.Click += delegate { SetContentView(Resource.Layout.Main); };
            Regi.Click += delegate { SetContentView(Resource.Layout.Register);
                RName = FindViewById<EditText>(Resource.Id.RName);
                RPass = FindViewById<EditText>(Resource.Id.RPass);
                REmail = FindViewById<EditText>(Resource.Id.REmail);
                RFName = FindViewById<EditText>(Resource.Id.RFName);
                RLName = FindViewById<EditText>(Resource.Id.RLName);
                RPass2 = FindViewById<EditText>(Resource.Id.RPass2);
                Button RegBut = FindViewById<Button>(Resource.Id.RegBut);
                    RegBut.Click += delegate { SetContentView(Resource.Layout.UMain);
                    UName = FindViewById<TextView>(Resource.Id.UsName);
                    UName.Text = RName.Text;
                    Button Search = FindViewById<Button>(Resource.Id.Movie);
                    Search.Click += delegate {
                        SetContentView(Resource.Layout.Search); 
                        Button TAdd = FindViewById<Button>(Resource.Id.TAdd);
                        Button SAdd = FindViewById<Button>(Resource.Id.SAdd);
                        Button DAdd = FindViewById<Button>(Resource.Id.DAdd);
                        Button TB1 = FindViewById<Button>(Resource.Id.TB1);
                        Button TB2 = FindViewById<Button>(Resource.Id.TB2);
                        Button TB3 = FindViewById<Button>(Resource.Id.TB3);
                        TB1.Click += delegate { TB1.Text = ""; };
                        TB2.Click += delegate { TB2.Text = ""; };
                        TB3.Click += delegate { TB3.Text = ""; };
                        Button SB1 = FindViewById<Button>(Resource.Id.SB1);
                        Button SB2 = FindViewById<Button>(Resource.Id.SB2);
                        Button SB3 = FindViewById<Button>(Resource.Id.SB3);
                        SB1.Click += delegate { SB1.Text = ""; };
                        SB2.Click += delegate { SB2.Text = ""; };
                        SB3.Click += delegate { SB3.Text = ""; };
                        Button DB1 = FindViewById<Button>(Resource.Id.DB1);
                        Button DB2 = FindViewById<Button>(Resource.Id.DB2);
                        Button DB3 = FindViewById<Button>(Resource.Id.DB3);
                        DB1.Click += delegate { DB1.Text = ""; };
                        DB2.Click += delegate { DB2.Text = ""; };
                        DB3.Click += delegate { DB3.Text = ""; };
                        Think = FindViewById<EditText>(Resource.Id.Think);
                        Star = FindViewById<EditText>(Resource.Id.Star);
                        Dir = FindViewById<EditText>(Resource.Id.Dir);
                        TAdd.Click += delegate {
                            if (TB1.Text == "")
                            {
                                TB1.Text = Think.Text;
                            }
                            else if (TB2.Text == "")
                            {
                                TB2.Text = Think.Text;
                            }
                            else
                            {
                                TB3.Text = Think.Text;
                            }

                        };
                        SAdd.Click += delegate {
                            if (SB1.Text == "")
                            {
                                SB1.Text = Star.Text;
                            }
                            else if (SB2.Text == "")
                            {
                                SB2.Text = Star.Text;
                            }
                            else
                            {
                                SB3.Text = Star.Text;
                            }

                        };
                        DAdd.Click += delegate {
                            if (DB1.Text == "")
                            {
                                DB1.Text = Dir.Text;
                            }
                            else if (DB2.Text == "")
                            {
                                DB2.Text = Dir.Text;
                            }
                            else
                            {
                                DB3.Text = Dir.Text;
                            }

                        };
                        SYS  = FindViewById<SeekBar>(Resource.Id.SYS);
                StartY = FindViewById<TextView>(Resource.Id.StartY);
                EYS = FindViewById<SeekBar>(Resource.Id.EYS);
                EndY = FindViewById<TextView>(Resource.Id.EndY);
                SYS.ProgressChanged += (object sender, SeekBar.ProgressChangedEventArgs e) => {  
                if (e.FromUser) {  
                    StartY.Text = string.Format("  Starting Year is {0}", e.Progress+1888);  
                }  
            };  
                EYS.ProgressChanged += (object sender, SeekBar.ProgressChangedEventArgs e) => {  
                if (e.FromUser) {  
                    EndY.Text = string.Format("  End Year is {0}", e.Progress+1888);  
                }  
            }; 
                    };
                };

            };
            Logi.Click += delegate {
                    SetContentView(Resource.Layout.Login);
                LEmail = FindViewById<EditText>(Resource.Id.LEmail);
                LPass = FindViewById<EditText>(Resource.Id.LPass);
                Button LBut = FindViewById<Button>(Resource.Id.LButt);
                LBut.Click += delegate {
                    SetContentView(Resource.Layout.UMain);
                    UName = FindViewById<TextView>(Resource.Id.UsName);
                    UName.Text = LEmail.Text;
                    Button Searchs = FindViewById<Button>(Resource.Id.Movie);
                    Searchs.Click += delegate {
                        SetContentView(Resource.Layout.Search);
                        Button TAdd = FindViewById<Button>(Resource.Id.TAdd);
                        Button SAdd = FindViewById<Button>(Resource.Id.SAdd);
                        Button DAdd = FindViewById<Button>(Resource.Id.DAdd);
                        Button TB1 = FindViewById<Button>(Resource.Id.TB1);
                        Button TB2 = FindViewById<Button>(Resource.Id.TB2);
                        Button TB3 = FindViewById<Button>(Resource.Id.TB3);
                        TB1.Click += delegate{ TB1.Text = ""; };
                        TB2.Click += delegate {  TB2.Text = ""; };
                        TB3.Click += delegate { TB3.Text = ""; };
                        Button SB1 = FindViewById<Button>(Resource.Id.SB1);
                        Button SB2 = FindViewById<Button>(Resource.Id.SB2);
                        Button SB3 = FindViewById<Button>(Resource.Id.SB3);
                        SB1.Click += delegate { SB1.Text = ""; };
                        SB2.Click += delegate { SB2.Text = ""; };
                        SB3.Click += delegate { SB3.Text = ""; };
                        Button DB1 = FindViewById<Button>(Resource.Id.DB1);
                        Button DB2 = FindViewById<Button>(Resource.Id.DB2);
                        Button DB3 = FindViewById<Button>(Resource.Id.DB3);
                        DB1.Click += delegate { DB1.Text = ""; };
                        DB2.Click += delegate { DB2.Text = ""; };
                        DB3.Click += delegate { DB3.Text = ""; };
                        Think = FindViewById<EditText>(Resource.Id.Think);
                        Star = FindViewById<EditText>(Resource.Id.Star);
                        Dir = FindViewById<EditText>(Resource.Id.Dir);
                        TAdd.Click += delegate { 
                            if (TB1.Text == "")
                            {
                                TB1.Text = Think.Text;
                            }
                            else if (TB2.Text == "")
                            {
                                TB2.Text = Think.Text;
                            }
                            else
                            {
                                TB3.Text = Think.Text;
                            }
                             
                        };
                        SAdd.Click += delegate {
                            if (SB1.Text == "")
                            {
                                SB1.Text = Star.Text;
                            }
                            else if (SB2.Text == "")
                            {
                                SB2.Text = Star.Text;
                            }
                            else
                            {
                                SB3.Text = Star.Text;
                            }

                        };
                        DAdd.Click += delegate {
                            if (DB1.Text == "")
                            {
                                DB1.Text = Dir.Text;
                            }
                            else if (DB2.Text == "")
                            {
                                DB2.Text = Dir.Text;
                            }
                            else
                            {
                                DB3.Text = Dir.Text;
                            }

                        };
                        SYS  = FindViewById<SeekBar>(Resource.Id.SYS);
                StartY = FindViewById<TextView>(Resource.Id.StartY);
                EYS = FindViewById<SeekBar>(Resource.Id.EYS);
                EndY = FindViewById<TextView>(Resource.Id.EndY);
                SYS.ProgressChanged += (object sender, SeekBar.ProgressChangedEventArgs e) => {  
                if (e.FromUser) {  
                    StartY.Text = string.Format("  Starting Year is {0}", e.Progress+1888);  
                }  
            };  
                EYS.ProgressChanged += (object sender, SeekBar.ProgressChangedEventArgs e) => {  
                if (e.FromUser) {  
                    EndY.Text = string.Format("  End Year is {0}", e.Progress+1888);  
                }  
            }; 
                    };
                };
                   
                };

            SearchP.Click += delegate { 
                SetContentView(Resource.Layout.Search); 
                Button TAdd = FindViewById<Button>(Resource.Id.TAdd);
                Button SAdd = FindViewById<Button>(Resource.Id.SAdd);
                Button DAdd = FindViewById<Button>(Resource.Id.DAdd);
                Button TB1 = FindViewById<Button>(Resource.Id.TB1);
                Button TB2 = FindViewById<Button>(Resource.Id.TB2);
                Button TB3 = FindViewById<Button>(Resource.Id.TB3);
                TB1.Click += delegate { TB1.Text = ""; };
                TB2.Click += delegate { TB2.Text = ""; };
                TB3.Click += delegate { TB3.Text = ""; };
                Button SB1 = FindViewById<Button>(Resource.Id.SB1);
                Button SB2 = FindViewById<Button>(Resource.Id.SB2);
                Button SB3 = FindViewById<Button>(Resource.Id.SB3);
                SB1.Click += delegate { SB1.Text = ""; };
                SB2.Click += delegate { SB2.Text = ""; };
                SB3.Click += delegate { SB3.Text = ""; };
                Button DB1 = FindViewById<Button>(Resource.Id.DB1);
                Button DB2 = FindViewById<Button>(Resource.Id.DB2);
                Button DB3 = FindViewById<Button>(Resource.Id.DB3);
                DB1.Click += delegate { DB1.Text = ""; };
                DB2.Click += delegate { DB2.Text = ""; };
                DB3.Click += delegate { DB3.Text = ""; };
                Think = FindViewById<EditText>(Resource.Id.Think);
                Star = FindViewById<EditText>(Resource.Id.Star);
                Dir = FindViewById<EditText>(Resource.Id.Dir);
                TAdd.Click += delegate {
                    if (TB1.Text == "")
                    {
                        TB1.Text = Think.Text;
                    }
                    else if (TB2.Text == "")
                    {
                        TB2.Text = Think.Text;
                    }
                    else
                    {
                        TB3.Text = Think.Text;
                    }

                };
                SAdd.Click += delegate {
                    if (SB1.Text == "")
                    {
                        SB1.Text = Star.Text;
                    }
                    else if (SB2.Text == "")
                    {
                        SB2.Text = Star.Text;
                    }
                    else
                    {
                        SB3.Text = Star.Text;
                    }

                };
                DAdd.Click += delegate {
                    if (DB1.Text == "")
                    {
                        DB1.Text = Dir.Text;
                    }
                    else if (DB2.Text == "")
                    {
                        DB2.Text = Dir.Text;
                    }
                    else
                    {
                        DB3.Text = Dir.Text;
                    }

                };
                SYS  = FindViewById<SeekBar>(Resource.Id.SYS);
                StartY = FindViewById<TextView>(Resource.Id.StartY);
                EYS = FindViewById<SeekBar>(Resource.Id.EYS);
                EndY = FindViewById<TextView>(Resource.Id.EndY);
                SYS.ProgressChanged += (object sender, SeekBar.ProgressChangedEventArgs e) => {  
                if (e.FromUser) {  
                    StartY.Text = string.Format("  Starting Year is {0}", e.Progress+1888);  
                }  
            };  
                EYS.ProgressChanged += (object sender, SeekBar.ProgressChangedEventArgs e) => {  
                if (e.FromUser) {  
                    EndY.Text = string.Format("  End Year is {0}", e.Progress+1888);  
                }  
            };  
            };
        }
    }
}

