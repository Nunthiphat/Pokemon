using Pokemon;

namespace Pokemon
{
    public partial class Form1 : Form
    {
        List<Pokemon> pokemons;
        Pokemon selectedPokemon;
        Pokemon monster;
        List<Pokemon> monsters;
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
            this.tbHP.Text = selectedPokemon.getHP().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[1];
            this.PicCharmander.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            this.tbName.Text = selectedPokemon.getHP().ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            monster = monsters[0];
            this.tbMonsHP.Text = this.monster.getHP().ToString();
            int damage = this.monster.getDefense() - this.selectedPokemon.getAttack();
            int Raw = int.Parse(this.tbMonsHP.Text);
            this.monster.takeDamage(damage);
            this.tbMonsHP.Text = (Raw - damage).ToString();
            //bool status = monster.DiedPokemon(int.Parse(this.tbMonsHP.Text));
            //this.tbHP.Text = int.Parse(this.selectedPokemon - this.tbHP.Text).ToString();
            //if (status)
            //{
            //    monster = pokemons[0];
            //}
            //else
            //{
            //    this.tbMonsHP.Text = (this.monster.getHP() - damage).ToString();
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[2];
            this.PicCharmander.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            this.tbName.Text = selectedPokemon.getHP().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[3];
            this.PicCharmander.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            this.tbName.Text = selectedPokemon.getHP().ToString();
        }
    }
}