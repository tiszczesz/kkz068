# Informacje wstępne JS

## Strony dev:

1. Mozilla: https://developer.mozilla.org/en-US/docs/Web/JavaScript
2. W3Schools:  https://www.w3schools.com/

# Informacje o Typescript: https://www.typescriptlang.org/

1. Typy w Typescript: https://www.typescriptlang.org/docs/handbook/2/everyday-types.html

# NodeJs

Strona główna: https://nodejs.org/en/

## Instalowanie pakietów npm

```console
npm init
npm install bootstrap
npm i jquery
//instalacja lokalna typescript
npm i typescript --save-dev
npx tsc -init

```

### Zmiany w tsconfig

```json
{
    "compilerOptions": {   
    "target": "ES2022",  
    "module": "ES6",                              
     "rootDir": "./src",   
     "outDir": "./dist",    
    "esModuleInterop": true,  
    "strict": true,  
    "skipLibCheck": true                                
  }
}

```

### Zmiany w package.json

```json
{
  "name": "xxx",
  "version": "1.0.0",
  "description": "",
  "main": "index.js",
  "module": "module",
  "scripts": {
    "test": "echo \"Error: no test specified\" && exit 1"
  },
  "author": "",
  "license": "ISC",
  "devDependencies": {
    "typescript": "^4.8.2"
  }
}

```

## Angular informacje
https://angular.io/

narzędzie online (piaskownica):

https://stackblitz.com/edit/angular-ivy-zrvkzc?file=src%2Fapp%2Fapp.component.ts

### Dzielenie informacji między komponentami:
https://angular.io/guide/inputs-outputs

## React  Informacje renderowanie po stronie klienta

### dokumentacja https://pl.reactjs.org/

### playground online:
https://codepen.io/pen?&editors=0010&layout=left

### Tworzenie aplikacji z typescriptem

```console
  npx create-react-app nowa-app --template typescript
```

## Next.js renderowanie po stronie serwera

https://nextjs.org/


## React-router
https://reactrouter.com/en/main

```console
npm i react-router-dom
```