const webpack = require("webpack");
const path = require('path');

module.exports = {
    //configureWebpack 是Vue CLI3.0 中用于配置 webpack 插件参数的地方，你在这里设置，会新建或者覆盖 webpack 默认配置。
    //webpack ProvidePlugin 的含义是创建一个全局的变量，使这个变量在 webpack 各个模块内都可以使用。这里的配置含义是创建 '$'、'jQuery'、'window.jQuery' 三个变量指向 jquery 依赖，创建 'Popper' 变量指向 popper.js 依赖。
    configureWebpack: {
        plugins: [
            new webpack.ProvidePlugin({
                $: 'jquery',
                jQuery: 'jquery',
                axios:'axios'
            })
        ],
        resolve: {
            extensions: ['.js', '.vue', '.json', '.ts'],
            alias: {
                'vue$': 'vue/dist/vue.esm.js',
                '@': path.resolve(__dirname, 'src'),
            }
        },
        module: {
            rules: [
                // {
                //     test: /\.(png|jpe?g|gif|svg)(\?.*)?$/,
                //     loader: 'url-loader',
                //     options: {
                //         limit: 10000,
                //         name: path.posix.join('./static', 'img/[name].[hash:7].[ext]')
                //     }
                // }
            ]
        }
    },
    baseUrl: './',
    outputDir: process.env.outputDir,
    indexPath: 'index.html',
    devServer: {
        host: "0.0.0.0",
        port: 8080,
        https: false,
        open: true
    }
}