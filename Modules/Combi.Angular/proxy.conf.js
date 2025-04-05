const apiConfig = {
    "target": "http://localhost:5017/",
    "secure": false,
    "ws": true,
    "logLevel": "debug",
    "pathRewrite": { "^/": "/" }
}

module.exports = {
    "/api/**": apiConfig
};