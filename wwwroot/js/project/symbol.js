
const info_symbol = document.querySelectorAll(".info_symbol");
const info_box = document.querySelectorAll(".info_box");

eventHandler(info_symbol, info_box, "click", "show", "multiple")

const stock_chart = document.getElementById('stock_chart').getContext("2d");
var priceGradient = stock_chart.createLinearGradient(0, 0, 0, 470);
    priceGradient.addColorStop(0, 'rgba(0, 153, 210, 0.3)');
    priceGradient.addColorStop(1, 'rgba(0, 153, 210, 0)');
var sma50Gradient = stock_chart.createLinearGradient(0, 0, 0, 470);
    sma50Gradient.addColorStop(0, 'rgba(110, 0, 210, 0.3)');
    sma50Gradient.addColorStop(1, 'rgba(110, 0, 210, 0)')
var sma100Gradient = stock_chart.createLinearGradient(0, 0, 0, 470);
    sma100Gradient.addColorStop(0, 'rgba(110, 255, 0, 0.3)');
    sma100Gradient.addColorStop(1, 'rgba(110, 255, 0, 0)');
var sma200Gradient = stock_chart.createLinearGradient(0, 0, 0, 470);
    sma200Gradient.addColorStop(0, 'rgba(0, 50, 255, 0.3)');
    sma200Gradient.addColorStop(1, 'rgba(0, 50, 255, 0)');
const stock_chart1 = new Chart(stock_chart, {
    type: "line",
    data: {
        labels: dates,
        datasets: [{
            label: 'Price',
            data: close,
            backgroundColor: priceGradient,
            borderColor: 'rgba(0, 153, 210, 1)',
            borderWidth: 2,
            fill: true,
        },
        {
            label: 'SMA (50)',
            data: sma50,
            backgroundColor: sma50Gradient,
            borderColor: 'rgba(110, 0, 255, 1)',
            borderWidth: 3,
            fill: true,
        },
        {
            label: 'SMA (100)',
            data: sma100,
            backgroundColor: sma100Gradient,
            borderColor: 'rgba(110, 255, 0, 1)',
            borderWidth: 3,
            fill: true,
        },
        {
            label: 'SMA (200)',
            data: sma200,
            backgroundColor: sma200Gradient,
            borderColor: 'rgba(0, 50, 255, 1)',
            borderWidth: 3,
            fill: true,
        }]
    },
    options: chartConfig(),
});


const chart_margin = document.getElementById('chart_margin');
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
            backgroundColor: "rgb(110, 255, 255)",
            borderColor: "rgb(110, 255, 255, 0.7)",
        }, {
            label: "P/E Ratio",
            data: peRatio,
            backgroundColor: "rgb(110, 255, 0)",
            borderColor: "rgb(110, 255, 0, 0.7)",
        }, {
            label: "P/B Ratio",
            data: pbRatio,
            backgroundColor: "rgb(138, 48, 255)",
            borderColor: "rgb(138, 48, 255, 0.7)",
            yAxisID: "right",
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
            backgroundColor: "rgb(20, 150, 255)",
            borderColor: "rgb(20, 150, 255, 0.7)",
            yAxisID: "right",
        }, {
            label: "Payout Ratio",
            data: payoutRatio,
            backgroundColor: "rgb(144, 0, 255)",
            borderColor: "rgb(144, 0, 255, 0.7)",
        }]
    },
    options: chartConfig("pct", true, "rgb(20, 150, 255)"),
});