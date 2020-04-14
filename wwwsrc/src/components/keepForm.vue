<template>
  <form id="keepForm" @submit.prevent="createKeep">
    <fieldset>
      <div class="form-group">
        <label for="exampleInputEmail1"></label>
        <input
          class="form-control"
          id="KeepName"
          v-model="newKeep.name"
          type="text"
          placeholder="Keep Name"
        />
      </div>
      <div class="form-group">
        <label></label>
        <input
          class="form-control"
          v-model="newKeep.img"
          id="KeepImg"
          type="text"
          placeholder="Img Url"
        />
      </div>
      <div class="form-group">
        <label></label>
        <textarea
          class="form-control"
          v-model="newKeep.description"
          id="keepDescription"
          placeholder="Keep Description"
          rows="3"
        ></textarea>
      </div>
    </fieldset>

    <button class="btn btn-primary mx-2" @click="createKeep" type="button">Create!</button>
    <button class="btn btn-danger mx-2" @click="cancelToggle" type="button">Cancel</button>
  </form>
</template>

<script>
export default {
  name: "keepForm",

  methods: {
    cancelToggle() {
      this.$emit("clicked");
    },

    createKeep() {
      this.$store.dispatch("createKeep", this.newKeep);
      this.$store.dispatch("getUserKeeps");
      this.$emit("clicked");
    }
  },
  data() {
    return {
      newKeep: {}
    };
  }
};
</script>

<style>
</style>