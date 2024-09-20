namespace BreakTimer;

public partial class MainPage : ContentPage
{
    //Countdown oCountdown = new Countdown();
    private bool isRunning = false;
    private bool isRed;
    

    public MainPage()
    {
        InitializeComponent();
    }

    private void Btn5min_OnClicked(object sender, EventArgs e)
    {
        btn5min.IsEnabled = false;
        btn10min.IsEnabled = false;
        btn15min.IsEnabled = false;

        int myTime = 5;
        lblDisplay.Text = myTime + " Minutes Left";
        
        Dispatcher.StartTimer(TimeSpan.FromMinutes(1), () =>
        {
            myTime--;
            lblDisplay.Text = myTime + " Minutes Left";

            if (myTime > 0)
            {
                isRunning = true;
                isRed = false;
                FtmMainPage.BackgroundColor = Colors.White;
            }
            else
            {
                isRunning = false;
                isRed = true;
            }

            if (isRed == true)
            {
                lblDisplay.Text = "Time's up!!!";
                FtmMainPage.BackgroundColor = Colors.Red;

                //int toggle;
                Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
                {
                    if (isRed)
                    {
                        FtmMainPage.BackgroundColor =Colors.Red;
                    }
                    else
                    {
                        FtmMainPage.BackgroundColor = Colors.White;
                    }

                    isRed = !isRed;
                    
                    return true;
                });
            }
            else
            {
                FtmMainPage.BackgroundColor = Colors.White;
            }
            
            return isRunning;
        });
    }

    private void Btn10min_OnClicked(object sender, EventArgs e)
    {
        btn10min.IsEnabled = false;
        btn5min.IsEnabled = true;
        btn15min.IsEnabled = true;

        int myTime = 10;
        lblDisplay.Text = myTime + " Minutes Left";
        
        Dispatcher.StartTimer(TimeSpan.FromMinutes(1), () =>
        {
            myTime--;
            lblDisplay.Text = myTime + " Minutes Left";

            if (myTime > 0)
            {
                isRunning = true;
                isRed = false;
                FtmMainPage.BackgroundColor = Colors.White;
            }
            else
            {
                isRunning = false;
                isRed = true;
            }

            if (isRed == true)
            {
                lblDisplay.Text = "Time's up!!!";
                FtmMainPage.BackgroundColor = Colors.Red;

                //int toggle;
                Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
                {
                    if (isRed)
                    {
                        FtmMainPage.BackgroundColor =Colors.Red;
                    }
                    else
                    {
                        FtmMainPage.BackgroundColor = Colors.White;
                    }

                    isRed = !isRed;
                    
                    return true;
                });
            }
            else
            {
                FtmMainPage.BackgroundColor = Colors.White;
            }
            
            return isRunning;
        });
    }

    private void Btn15min_OnClicked(object sender, EventArgs e)
    {
        btn5min.IsEnabled = true;
        btn10min.IsEnabled = true;
        btn15min.IsEnabled = false;
        

        int myTime = 15;
        lblDisplay.Text = myTime + " Minutes Left";
        
        Dispatcher.StartTimer(TimeSpan.FromMinutes(1), () =>
        {
            myTime--;
            lblDisplay.Text = myTime + " Minutes Left";

            if (myTime > 0)
            {
                isRunning = true;
                isRed = false;
                FtmMainPage.BackgroundColor = Colors.White;
            }
            else
            {
                isRunning = false;
                isRed = true;
            }

            if (isRed == true)
            {
                lblDisplay.Text = "Time's up!!!";
                FtmMainPage.BackgroundColor = Colors.Red;

                //int toggle;
                Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
                {
                    if (isRed)
                    {
                        FtmMainPage.BackgroundColor =Colors.Red;
                    }
                    else
                    {
                        FtmMainPage.BackgroundColor = Colors.White;
                    }

                    isRed = !isRed;
                    
                    return true;
                });
            }
            else
            {
                FtmMainPage.BackgroundColor = Colors.White;
            }
            
            return isRunning;
        });
    }
}