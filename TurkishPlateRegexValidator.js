const readline = require('readline');

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

function validatePlate(plate) {
  const pattern = /^(0[1-9]|[1-7][0-9]|8[01])\s((?:[A-Z]\s\d{4,5})|(?:[A-Z]{2}\s\d{3,4})|(?:[A-Z]{3}\s\d{2,3}))$/;
  return pattern.test(plate);
}

function askPlate() {
  rl.question('Please enter a plate number (type "exit" to quit): ', (input) => {
    if (input.toLowerCase() === 'exit') {
      console.log('Terminating the application...');
      rl.close(); 
    } else {
      if (validatePlate(input)) {
        console.log('Plate is valid.\n');
      } else {
        console.log('Plate is invalid.\n');
      }
      askPlate();
    }
  });
}

askPlate();
