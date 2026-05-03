// Loop from 1 to 15
for (let i = 1; i <= 15; i++) {
  // Check multiples of both 3 and 5 first
  if (i % 3 === 0 && i % 5 === 0) {
    console.log("FizzBuzz");
  } 
  else if (i % 3 === 0) {
    console.log("Fizz");
  } 
  else if (i % 5 === 0) {
    console.log("Buzz");
  } 
  else {
    console.log(i);
  }
}