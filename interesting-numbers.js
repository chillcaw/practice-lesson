const readline = require("readline");

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

async function app() {
    while (true) {
        const rawInput = await new Promise(resolve => {
            rl.question("Please enter a number: ", resolve);
        });

        if (rawInput == "x") {
            break;
        } else {
            const n = parseInt(rawInput);

            isPrime = true;
            endsIn5Or3 = false;
            digitsSum10 = false;

            console.log("Logging n", n);

            for (let i = n - 1; i > 1; --i) {
                if (n % i === 0) {
                    isPrime = false;
                }
            }

            const nString = "" + n;

            let sum = 0;
            
            for (let i = 0; i < nString.length; ++i) {
                sum += +nString[i];
            }

            if (sum === 10) {
                digitsSum10 = true;
            }

            let lastDigit = +nString[nString.length - 1];

            if (lastDigit === 5 || lastDigit === 3) {
                endsIn5Or3 = true;
            }

            console.log("Is it Prime?", isPrime);
            console.log("Does it end in 3 or 5?", endsIn5Or3);
            console.log("Digits add to 10?", digitsSum10);

            if (isPrime === true && endsIn5Or3 == true && digitsSum10 === true) {
                console.log(`The number => ${n} is very interesting`);
            } else if (isPrime === true && endsIn5Or3 == true) {
                console.log(`The number => ${n} is interesting`);
            } else if (endsIn5Or3 == true && digitsSum10 === true) {
                console.log(`The number => ${n} is interesting`);
            } else if (isPrime === true && digitsSum10 === true) {
                console.log(`The number => ${n} is interesting`);
            } else if (isPrime === true || endsIn5Or3 == true || digitsSum10 === true) {
                console.log(`The number => ${n} is almost interesting`);
            } else {
                console.log(`The number => ${n} is boring`);
            }
        }
    }

    rl.close();

    console.log("Goodbye");
}

app();