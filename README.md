# Call Log Tracker
This is an application for tracking phone calls in the workplace. It uses a MariaDB database backend for data storage and allows for multiple users to use the application at a time.

Feature List:
  * Input call data including: caller name, call back number, message, caller email, and if the call is important.
  * Mark calls as resolved when taken care of.
  * Add/edit users and companies for the application
    * A company is considered to be the organization taking the phone calls.
    * A user is the person taking the phone call within the organization.
  * Notify users of all calls, resolved calls, or unresolved calls by email or text message (SMS).
  * View calls using a variety of filters:
    * Filter by calls taken today, calls taken by the current user or all users, and calls that are resolved or unresolved.
  * Configuration file for specifying API credentials for the Email and SMS APIs.

This project uses Twilio to send SMS messages and Twilio SendGrid for sending Emails. The API credentials are specified in a file called <code>config.cfg</code> to help ensure credentials stay confidential.

**NO API CREDENTIALS ARE SUPPLIED WITH THE APPLICATION**
*To use the APIs, sign up for an account at https://www.twilio.com (SMS API) and https://sendgrid.com (Email API)*. Refer to those site's documentation for information on how to get API access. Then, edit <code>config.cfg</code> with the corresponding values. The application will not work until valid API credentials are supplied.
