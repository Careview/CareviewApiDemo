# Careview Api Demo

The Careview API is REST JSON. This repository has sample code on how to consume the API and interact with Careview.

<br>

## Getting Started

You will need a subscription key to use the Careview API. [Contact us](http://www.careviewapp.com/contact-us) to have one provisioned for you.

In Careview go into settings, under Integration > Configure API Access [https://app.careview.io/Settings/ApiKeys](https://app.careview.io/Settings/ApiKeys). Here you can create an API key mapped to one of your organisation's user accounts. Go to New, and select the user account for which API calls will act on behalf of. After saving, take note of the generated key. That key is what needs to be passed into the header of each API request. All API activity using the key will assume the identity of that user.

The API key is used in the header of the request (header key "ApiKey"). The subscription key is appended on each call in the URL with a parameter "subscription-key", eg https://careview.azure-api.net/test/clients/get/{ndisNumber}?subscription-key=(Your API Key Here)

## API Endpoint
 
- The API endpoint for production is: https://careview.azure-api.net

- For the test sandbox: https://careview.azure-api.net/test

## Sandbox Environment for CRM

You can access a sandbox version of Careview to see changes made into test. Log in to: https://careview-sbox-web.azurewebsites.net
