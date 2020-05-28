<template>
  <div id="todolist">
    <div>
      <input class="item" v-model="inputvalue" />
      <button @click="handleSubmit">提交</button>
    </div>
    <ul>
      <todo-item v-for="(item, index) in list" :key="index" :content='item' :index='index' @delete='handelDel'></todo-item>
    </ul>
  </div>
</template>

<script>
import todoitem from './components/todoitem'
export default {
  components: {
    'todo-item': todoitem
  },
  data () {
    return {
      inputvalue: '',
      list: []
    }
  },
  methods: {
    handleSubmit () {
      this.list.push(this.inputvalue)
      this.inputvalue = ''
    },
    handelDel (index) {
      this.list.splice(index, 1)
    }
  }
}
</script>

<style>
</style>
