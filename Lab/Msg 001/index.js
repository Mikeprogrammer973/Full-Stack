// Método 1
/*
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
*/

// Método 2
const accountSid = 'ACe5332a0668b418772a6937ee7c579891';
const authToken = '0b574194176cd7366cedf1ef7f8ea062';
const client = require('twilio')(accountSid, authToken);

function send_msg(msg, to){
  client.messages
    .create({
        body: msg,
        mediaUrl: ['https://live-s3-bucket-sjwburhj9xhf.cdn.live.tandem.net/e2/19/90b1181cd60ae0688ff15047894eb337.jpg'],
        from: 'whatsapp:+14155238886',
        to: `whatsapp:${to}`
    })
    .then(message => console.log(message.sid))
}

const fs = require('fs')
const readline = require('readline')

async function get_nums(file) {
  const fileStream = fs.createReadStream(file);
  const rl = readline.createInterface({
    input: fileStream,
    crlfDelay: Infinity
  })
  for await (const line of rl) {
    console.log(line)
    send_msg("We're going on!", line)
  }
}
 
get_nums('./Lab/Msg 001/nums.txt')
