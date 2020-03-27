const SUBSCRIPTION_KEY = '';
const API_KEY = '';
const TEST = true;

function getEndpoint() {
    return TEST
        ? 'https://careview.azure-api.net/test'
        : 'https://careview.azure-api.net';
}


function validateInvoice(invoice) {
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

    xmlhttp.open('POST', `${getEndpoint()}/invoicing/validate?subscription-key=${SUBSCRIPTION_KEY}`, true);
    xmlhttp.setRequestHeader('ApiKey', API_KEY);
    xmlhttp.send();
}


function createInvoice(invoice) {
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

    xmlhttp.open('POST', `${getEndpoint()}/invoicing/create?subscription-key=${SUBSCRIPTION_KEY}`, true);
    xmlhttp.setRequestHeader('ApiKey', API_KEY);
    xmlhttp.send();
}


validateInvoice({
    clientNdisNumber = '123456789',
    invoiceLines = [
        {
            deliveredDate = new Date(2019, 11, 20),
            supportItemNumber = '01_002_0107_1_1',
            gstCode = 'P2',
            quantity = 1,
            rate = 55
        }
    ]
});

createInvoice({
    clientNdisNumber = '123456789',
    serviceProviderAbn = '123456789',
    providerInvoiceNumber = 'invtest-123',
    providerInvoiceDate = new DateTime(2019, 7, 3),
    approvedByClient = false,
    notes = 'test 123-456',
    invoiceLines = [
        {
            type = 'STAND',
            deliveredDate = new DateTime(2019, 7, 3),
            planCategoryId = '1',
            supportItemNumber = '01_002_0107_1_1',
            gstCode = 'P2',
            quantity = 1,
            rate = 55,
        }
    ]
});
