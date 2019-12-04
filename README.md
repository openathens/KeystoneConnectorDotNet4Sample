# OpenAthens Keystone .NET 4.5 MVC Sample
This is a simple example of using OpenID Connect authentication with OpenAthens Keystone in a .NET 4.5+ MVC web application.

## Getting started
1. Clone the repository: `git clone https://github.com/openathens/KeystoneConnectorDotNet4Sample`
1. Create a new Application record in the OpenAthens [Service Provider dashboard](https://sp.openathens.net/), using:
   1. Type: OpenID Connect
   1. Application URL `https://localhost:44328` (no trailing slash)
   1. Redirect URL `https://localhost:44328/` (with trailing slash)
1. Update the appSettings in Web.config with the Client Id and Client Secret from the application record created above
 (these can be found on the Configuration tab).
1. If you haven't already done so, create a test personal account in the OpenAthens
 [Identity Provider dashboard](https://admin.openathens.net/).
1. Run the application and browse to [https://localhost:44328/](https://localhost:44328/)
1. The `Login` link should take you to OpenAthens; log in with your test personal account and it will take you back to
 your site.
1. Follow the `Cliams` link to view the OpenID Connect claims associated with your personal account. The one of most
 interest is `eduPersonScopedAffiliation` which is in the format `{AFFILIATION}@{SCOPE}`. `{SCOPE}` represents the 
 organisation that the user belongs to, and `{AFFILIATION}` is the type of user, which defaults to 'member'. In a real 
 world application you would access this claim in a page master to decide whether to grant the user access to pages
 based on that master. If you only want some users in an organisation to have access, instead of all, ask them to set up
 different values of `{AFFILIATION}` for different groups of users.
