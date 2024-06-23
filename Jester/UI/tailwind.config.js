/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "**/*.ts",
    "../**/*.cshtml"
  ],
  theme: {
    container: {
      center: true,
    },
    extend: {
      minHeight: {
        "6": "1.5rem"
      }
    },
  },
  plugins: [],
}

