<template>
  <div id="app">
    <!-- <img src="./assets/logo.png"> -->
    <!-- <v-list message="abc"></v-list> -->
    <hui-table 
      dataurl="https://raw.githubusercontent.com/alucardlockon/RESTfulTest/master/node-vue-test-play/static/json/tabledata.json">
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
