# OpenAthens Keystone .NET 4.5 MVC Sample
This is a simple example of using OpenID Connect authentication with OpenAthens Keystone in a .NET 4.5+ MVC web application.

## Getting started
1. Clone the repository: `git clone https://github.com/openathens/KeystoneConnectorDotNet4Sample`
1. Create a new Application record in the OpenAthens [Service Provider dashboard](https://sp.openathens.net/), using:
  a. Type: OpenID Connect
  a. Application URL `https://localhost:44328`
  a. Redirect URL `https://localhost:44328/`
1. Update the appSettings in Web.config with the Client Id and Client Secret from the application record created above.
