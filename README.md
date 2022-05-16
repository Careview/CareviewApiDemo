# Careview Api Demo

The Careview API is REST JSON. This repository has sample code on how to consume the API and interact with Careview.

## Getting Started

You will need a subscription key to use the Careview API. [Contact us](http://www.careviewapp.com/contact-us) to have one provisioned for you.

In Careview go into settings, under Integration > Configure API Access [https://app.careview.io/Settings/ApiKeys](https://app.careview.io/Settings/ApiKeys). Here you can create an API key mapped to one of your organisation's user accounts. Go to New, and select the user account for which API calls will act on behalf of. After saving, take note of the generated key. That key is what needs to be passed into the header of each API request. All API activity using the key will assume the identity of that user.

The API key must be sent as a header on every request and must use the header name 'ApiKey' (case sensitive) eg `xmlhttp.setRequestHeader('ApiKey', API_KEY);`.

The Subscription key must be appended to every request as a request parameter using the param name 'subscription-key' (case sensitive) eg `xmlhttp.open('GET', url + '?subscription-key=' + SUBSCRIPTION_KEY);` aka `'https://careview.azure-api.net/clients/get/123456789?subscription-key=' + SUBSCRIPTION_KEY`

Your API key is provided to you from Careview and takes the format XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX

Your Subscription key is the same as your API key, with the dashes manually removed: XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

## API URLs
 
- The API url for production is: https://careviewapi.azurewebsites.net

- For the test sandbox: https://careview-test-api.azurewebsites.net

## Swagger Documentation

Refer to [https://apidocs.careview.io](https://apidocs.careview.io) for reference on API methods.
