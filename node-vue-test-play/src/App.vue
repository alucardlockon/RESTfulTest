<template>
  <div id="app">
    <!-- <img src="./assets/logo.png"> -->
    <!-- <v-list message="abc"></v-list> -->
    <!-- dataurl="https://raw.githubusercontent.com/alucardlockon/RESTfulTest/master/node-vue-test-play/static/json/tabledata.json" -->
    <hui-table 
      dataurl="static/json/tabledata.json"
      page-size="10"
      show-line-number="true"
      >
    </hui-table>
    <!-- <button class="btn btn-primary">Save</button> -->
  </div>
</template>

<script>
import Hello from './components/Hello'
import VList from './components/VList'
import HuiTable from './components/HuiTable'

export default {
  name: 'app',
  components: {
    Hello, VList, HuiTable
  }
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
