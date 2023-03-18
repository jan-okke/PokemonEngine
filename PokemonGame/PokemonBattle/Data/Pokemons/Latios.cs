using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Latios : Pokemon
	{
		public override string Name => "Latios";
		public override List<Ability> AvailableAbilities => new() {new Levitate() };
		public override Stats BaseStats => new Stats(80, 90, 80, 110, 130, 110);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Storedpower(), new Dragondance() },
			[5] = new List<Move>() { new Helpinghand() },
			[10] = new List<Move>() { new Recover() },
			[15] = new List<Move>() { new Confusion() },
			[20] = new List<Move>() { new Tailwind() },
			[25] = new List<Move>() { new Dragonbreath() },
			[30] = new List<Move>() { new Allyswitch() },
			[35] = new List<Move>() { new Lusterpurge() },
			[40] = new List<Move>() { new Zenheadbutt() },
			[45] = new List<Move>() { new Dragonpulse() },
			[50] = new List<Move>() { new Healpulse() },
			[55] = new List<Move>() { new Simplebeam() },
			[60] = new List<Move>() { new Psychic() },
			[65] = new List<Move>() { new Powersplit() },
			[70] = new List<Move>() { new Memento() },
			[75] = new List<Move>() { new Psychoshift() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Airslash(), new Allyswitch(), new Attract(), new Aurasphere(), new Batonpass(), new Bodyslam(), new Breakingswipe(), new Bulldoze(), new Calmmind(), new Chargebeam(), new Cut(), new Defog(), new Dive(), new Doubleteam(), new Dracometeor(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Dreameater(), new Dualwingbeat(), new Earthquake(), new Endure(), new Energyball(), new Facade(), new Flash(), new Fly(), new Futuresight(), new Gigaimpact(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icywind(), new Lightscreen(), new Mysticalfire(), new Outrage(), new Protect(), new Psychic(), new Psychocut(), new Psychup(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Retaliate(), new Roar(), new Roost(), new Round(), new Safeguard(), new Sandstorm(), new Scaleshot(), new Shadowball(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Steelwing(), new Storedpower(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Triattack(), new Trick(), new Waterfall(), new Waterpulse(), new Whirlpool(), new Wonderroom(), new Zenheadbutt() };
		public override int Weight => 600;
		public override int ExpYield => 300;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}