const API_KEY = ''; // your API key from careview in the format XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX
const SUBSCRIPTION_KEY = ''; // the subscription key is the same as the API key, with the dashes removed
const TEST = true;

function getEndpoint() {
    return TEST
        ? 'https://careview-test-api.azurewebsites.net'
        : 'https://careviewapi.azurewebsites.net';
}


function getClient(ndisNumber) {
    var XMLHttpRequest = require('xmlhttprequest').XMLHttpRequest;
    var xmlhttp = new XMLHttpRequest();

    xmlhttp.onreadystatechange = function () {
        if (xmlhttp.readyState === 4) {
            if (xmlhttp.status === 200) {
                console.log(xmlhttp.responseText);
            } else {
                console.log('Error: ' + JSON.parse(xmlhttp.responseText).message);
            }
        }
    };
    
    xmlhttp.open('GET', `${getEndpoint()}/clients/get/${ndisNumber}?subscription-key=${SUBSCRIPTION_KEY}`, true);
    xmlhttp.setRequestHeader('ApiKey', API_KEY);
    xmlhttp.send();
}


function searchClient(search) {
    var XMLHttpRequest = require('xmlhttprequest').XMLHttpRequest;
    var xmlhttp = new XMLHttpRequest();

    xmlhttp.onreadystatechange = function () {
        if (xmlhttp.readyState === 4) {
            if (xmlhttp.status === 200) {
                console.log(xmlhttp.responseText);
            } else {
                console.log('Error: ' + JSON.parse(xmlhttp.responseText).message);
            }
        }
    };
    
    xmlhttp.open('POST', `${getEndpoint()}/clients/search?subscription-key=${SUBSCRIPTION_KEY}`, true);
    xmlhttp.setRequestHeader('ApiKey', API_KEY);
    xmlhttp.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
    var params = 'term=' + search;
    xmlhttp.send(params);
}


getClient('123456789');
searchClient('ard');
