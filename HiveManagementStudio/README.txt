The first and most important note to make for this application is that it is in pre-pre-pre-alpha mode.
It's definitely a work in progress, but at this point, it's working and usable against a real cluster.

Some important notes regarding usage of Hive Query Studio (HQS)

- It is compiled as a 64bit application. This means that you'll need the 64 Bit Hive ODBC driver
	- additionally, DSNs (Data Source Names) will have to be created using the 64bit version of the tool

- It currently only runs on Windows (obviously)

- This application will *probably* be released under some sore of GNU based open-source license, but not sure yet, so please don't share around until
  I decide when to do a more formal release of the application.


GENERAL USAGE NOTES

 Right now, HQS is pretty simple. It allows you to connect to a predefined DSN using the Microsoft Hive ODBC driver.  You'll have to enter a password, but it will 
 attempt to pull the username from the DSN configuration.

 Once connected you can send queries to the cluster. It doesn't do any sort of syntax validation, so be careful with what you enter. It is actually smart enough
 to fail gracefully (most of the time!) and will display any error messages returned from the ODBC driver in the Messages tab.

 Results can be sorted, copied, etc -- which is one of the big reasons that I really wanted to create an application like this.  Using the console, or a 
 web interface wasn't the best experience to explore data store in Hive.

 THE FUTURE

 I have lots of ideas for HQS -- database object browsing, syntax validation, etc...but those are all future desiers. I welcome all feedback, please forward any suggestions to me!

 -josh