var path = require('path');
//定义了一些文件夹的路径
// var ROOT_PATH = path.resolve(__dirname);
// var APP_PATH = path.resolve(ROOT_PATH, 'src');
//var BUILD_PATH = path.resolve(ROOT_PATH, 'build');

const config = {
  entry: './src/ts/go.js',
  output: {
    path: './build/js',
    filename: 'bundle.js'
  },
  module: {
    loaders: [
      {
        test: /\.ts?$/,
        loader: 'ts-loader'
      },
      {
        test: /\.less$/,
        loaders: ['style', 'css', 'less'],
        include: './src/less'
      },
      {
        test: /\.jsx?$/,
        loader: 'babel',
        include: './src/js',
        query: {
          presets: ['es2015']
        }
      }
    ]
  },
  devtool: 'eval'
}
module.exports = config