# Careview Api Demo

The Careview API is REST JSON. This repository has sample code on how to consume the API and interact with Careview.

<br>

## Getting Started

You will need a subscription key to use the Careview API. [Contact us](http://www.careviewapp.com/contact-us) to have one provisioned for you.

In Careview go into settings, under Integration > Configure API Access [https://app.careview.io/Settings/ApiKeys](https://app.careview.io/Settings/ApiKeys). Here you can create an API key mapped to one of your organisation's user accounts. Go to New, and select the user account for which API calls will act on behalf of. After saving, take note of the generated key. That key is what needs to be passed into the header of each API request. All API activity using the key will assume the identity of that user.

The API key is used in the header of the request (header key "ApiKey"). The subscription key is appended on each call in the URL with a parameter "subscription-key". The format is: https://careview.azure-api.net/clients/get/{ndisNumber}?subscription-key=(Your subscription key here). So for example if the client NDIS number is '1234' and the subscription key is 'abc123' then the URL is: 'https://careview.azure-api.net/clients/get/1234?subscription-key=abc123'.

<br>

## API Endpoint
 
- The API endpoint for production is: https://careview.azure-api.net

<br>

## Swagger Documentation

Refer to [https://apidocs.careview.io](https://apidocs.careview.io) for reference on API methods.
