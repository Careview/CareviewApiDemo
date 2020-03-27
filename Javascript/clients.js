const SUBSCRIPTION_KEY = '';
const API_KEY = '';
const TEST = true;

function GetEndpoint() {
    return TEST
        ? 'https://careview.azure-api.net/test'
        : 'https://careview.azure-api.net';
}


function getClient(ndisNumber) {
    var XMLHttpRequest = require("xmlhttprequest").XMLHttpRequest;
    var xmlhttp = new XMLHttpRequest();

    xmlhttp.onreadystatechange = function () {
        if (xmlhttp.readyState === 4) {
            if (xmlhttp.status === 200) {
                console.log(xmlhttp.responseText);
            } else if (xmlhttp.status === 400) {
                console.log('Error 400.');
            } else {
                console.log('Unknown Error.');
            }
        }
    };

    xmlhttp.open('GET', `${GetEndpoint()}/clients/get/${ndisNumber}?subscription-key=${SUBSCRIPTION_KEY}`, true);
    xmlhttp.setRequestHeader('ApiKey', API_KEY);
    xmlhttp.send();
}


getClient('');
