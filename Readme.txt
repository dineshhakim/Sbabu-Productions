Install DNVM:

@powershell -NoProfile -ExecutionPolicy unrestricted -Command �&{$Branch=�dev�;iex ((new-object net.webclient).DownloadString(�https://raw.githubusercontent.com/aspnet/Home/dev/dnvminstall.ps1�))}�


DNx MigrationsL

dnx  ef migrations add newPortfolio


dnx ef database update