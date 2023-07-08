// Método 1
var myHeaders = new Headers();
myHeaders.append("Content-Type", "application/x-www-form-urlencoded");

var urlencoded = new URLSearchParams();
urlencoded.append("token","2ht5sgm13r4epk1k");
urlencoded.append("to","+526864631922");
urlencoded.append("body","Go on!");


var requestOptions = {
  method: 'POST',
  headers: myHeaders,
  body: urlencoded,
  redirect: 'follow'
};

fetch("https://api.ultramsg.com/instance53575/messages/chat", requestOptions)
  .then(response => response.text())
  .then(result => console.log(result))
  .catch(error => console.log('error', error));


// Método 2
const accountSid = 'ACe5332a0668b418772a6937ee7c579891';
const authToken = '0b574194176cd7366cedf1ef7f8ea062';
const client = require('twilio')(accountSid, authToken);

for(let i = 0; i < 10; i++){
    client.messages
    .create({
        body: 'Your appointment is coming up on July 21 at 3PM',
        from: 'whatsapp:+14155238886',
        to: 'whatsapp:+5216864631922'
    })
    .then(message => console.log(message.sid))
}