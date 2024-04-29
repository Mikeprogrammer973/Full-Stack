
const accountSid = '';
const authToken = '';
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
 
get_nums('./nums.txt')
