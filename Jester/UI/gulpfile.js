const gulp = require('gulp');
const sass = require('gulp-sass')(require('node-sass'));
const sourcemaps = require('gulp-sourcemaps');
const webpack = require('webpack-stream');
const webpackConfig = require('./webpack.config.js');
const postcss = require('gulp-postcss');
const tailwindcss = require('tailwindcss');
const autoprefixer = require('autoprefixer');
const concat = require("gulp-concat"); 

// Compile SCSS to CSS
gulp.task('sass', function () {
    const plugins = [
        tailwindcss('./tailwind.config.js'),
        autoprefixer({}),
    ];

    return gulp.src('scss/*.scss')
        .pipe(sourcemaps.init())
        .pipe(sass().on('error', sass.logError))
        .pipe(postcss(plugins))
        .pipe(concat({ path: "main.css" }))
        .pipe(gulp.dest('../wwwroot/css'));
});

// Compile TypeScript to JavaScript using Webpack
gulp.task('typescript', () => {
    return gulp.src('ts/main.ts')
        .pipe(webpack(webpackConfig))
        .pipe(gulp.dest('../wwwroot/js'));
});

// Watch for file changes
gulp.task('watch', function () {
    gulp.watch('scss/**/*.scss', gulp.series('sass'));
    gulp.watch(['ts/**/*.ts', '../**/*.cshtml'], gulp.series('typescript'));
});

//build and watch
gulp.task('dev', gulp.series('sass', 'typescript', 'watch'));

// Default task
gulp.task('default', gulp.series('sass', 'typescript'));