
var formatter = new Intl.NumberFormat('en-US', {
    style: 'currency',
    currency: 'USD',
    maximumFractionDigits: 3, 
});

const dollar = document.querySelectorAll(".dollar");
dollar.forEach(d => {
    x = formatter.format(d.innerHTML)
    d.innerHTML = x
})

