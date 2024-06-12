const path = require('path');

module.exports = {
    entry: './ts/main.ts',
    mode: process.env.NODE_ENV === 'production' ? 'production' : 'development',
    output: {
        path: path.resolve(__dirname, 'wwwroot/js'),
        filename: 'main.js',
        chunkFilename: 'chunk.[hash].js'
    },
    module: {
        rules: [
            {
                test: /\.tsx?$/,
                use: 'ts-loader',
                exclude: /node_modules/
            },
            {
                test: /\.scss$/,
                use: [
                    'css-loader',
                    'postcss-loader',
                    'sass-loader'
                ]
            }
        ]
    },
    resolve: {
        extensions: ['.tsx', '.ts', '.js']
    }
};