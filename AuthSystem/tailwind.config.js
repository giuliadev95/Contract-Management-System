/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        './Pages/**/*.cshtml',
        './Views/**/*.cshtml',
        './Areas/**/*.cshtml',
        './wwwroot/**/*.html',

    ],
  theme: {
      extend: {
          colors: {
              primary: '#ffffff',
              accent: '#fbbf24',
              textBase: '000000',
          },
          fontFamily: {
              sans: ['Roboto', 'sans-serif'],
          }, 
      },
  },
  plugins: [],
}

