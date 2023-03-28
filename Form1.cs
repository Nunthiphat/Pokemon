using Pokemon;

namespace Pokemon
{
    public partial class Form1 : Form
    {
        List<Pokemon> pokemons;
        Pokemon selectedPokemon;
        Pokemon monster;
        public Form1()
        {
            InitializeComponent();

            pokemons = new List<Pokemon>();
            pokemons.Add(new Charmander());
            pokemons.Add(new Charmeleon());
            pokemons.Add(new Charizard());
            pokemons.Add(new MegaCharizard());

            this.monster = new Bulbasaur();
            this.PicBulbasaur.Image = this.monster.getImage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[0];
            this.PicCharmander.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[1];
            this.PicCharmander.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int damage = this.monster.getDefense() - this.selectedPokemon.getAttack();
            this.monster.takeDamage(damage);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[2];
            this.PicCharmander.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[3];
            this.PicCharmander.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
        }
    }
}