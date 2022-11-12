
const info_symbol = document.querySelectorAll(".info_symbol")
const info_box = document.querySelectorAll(".info_box")

eventHandler(info_symbol, info_box, "click", "show", "multiple")

const stock_chart = document.getElementById('stock_chart').getContext("2d")

function gradient(color, limit, colorLimit) {
    color = color.replace(")", "")
    let gradient = stock_chart.createLinearGradient(0, 0, 0, limit)
    gradient.addColorStop(0, `${color}, ${colorLimit})`)
    gradient.addColorStop(1, `${color}, 0)`)
    return gradient
}
let turqois = 'rgba(0, 153, 210)'
let green = 'rgba(0, 255, 110)'
let blue = 'rgba(0, 110, 255)'
let purple = 'rgba(153, 0, 255)'

const stock_chart1 = new Chart(stock_chart, {
    type: "line",
    data: {
        labels: dates,
        datasets: [{
            label: 'Price',
            data: close,
            backgroundColor: gradient(turqois, 470, 0.3),
            borderColor: 'rgba(0, 153, 210)',
            borderWidth: 2,
            fill: true,
        },
        {
            label: 'SMA (50)',
            data: sma50,
            backgroundColor: gradient(purple, 470, 0.3),
            borderColor: purple,
            borderWidth: 3,
            fill: true,
        },
        {
            label: 'SMA (100)',
            data: sma100,
            backgroundColor: gradient(green, 470, 0.3),
            borderColor: green,
            borderWidth: 3,
            fill: true,
        },
        {
            label: 'SMA (200)',
            data: sma200,
            backgroundColor: gradient(blue, 470, 0.3),
            borderColor: blue,
            borderWidth: 3,
            fill: true,
        }]
    },
    options: chartConfig(),
});


const chart_margin = document.getElementById('chart_margin')
const chart_margin1 = new Chart(chart_margin, {
    type: "bar",
    data: {
        labels: years,
        datasets: [{
            label: "Gross Margin",
            data: grossMargin,
            backgroundColor: "rgb(0, 110, 255)",
        }, {
            label: "Operating Margin",
            data: operatingMargin,
            backgroundColor: "rgb(20, 150, 255)",
        }, {
            label: "Profit Margin",
            data: profitMargin,
            backgroundColor: "rgb(20, 200, 240)",
        },],
    },
    options: chartConfig("pct"),
});

const chart_ratio = document.getElementById('chart_ratio');
const chart_ratio1 = new Chart(chart_ratio, {
    type: 'line',
    data: {
        labels: years,
        datasets: [{
            label: "EPS",
            data: eps,
            backgroundColor: gradient(blue, 250, 0.3),
            borderColor: blue,
            fill: true,
        }, {
            label: "P/E Ratio",
            data: peRatio,
            backgroundColor: gradient(green, 250, 0.3),
            borderColor: green,
            fill: true,
        }, {
            label: "P/B Ratio",
            data: pbRatio,
            backgroundColor: gradient(purple, 250, 0.3),
            borderColor: purple,
            yAxisID: "right",
            fill: true,
        },],
    },
    options: chartConfig("normal", true, "rgb(138, 48, 255)"),
});

const chart_dividend = document.getElementById('chart_dividend');
const chart_dividend1 = new Chart(chart_dividend, {
    type: 'line',
    data: {
        labels: years,
        datasets: [{
            label: "Dividend in %",
            data: dividendYield,
            backgroundColor: gradient(turqois, 250, 0.3),
            borderColor: turqois,
            yAxisID: "right",
            fill: true,
        }, {
            label: "Payout Ratio",
            data: payoutRatio,
            backgroundColor: gradient(purple, 250, 0.3),
            borderColor: purple,
            fill: true,
        }]
    },
    options: chartConfig("pct", true, "rgb(20, 150, 255)"),
});