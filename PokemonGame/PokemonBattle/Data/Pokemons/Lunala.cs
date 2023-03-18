using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Lunala : Pokemon
	{
		public override string Name => "Lunala";
		public override List<Ability> AvailableAbilities => new() {new Shadowshield() };
		public override Stats BaseStats => new Stats(137, 113, 89, 97, 137, 107);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moongeistbeam() },
			[1] = new List<Move>() { new Moongeistbeam(), new Cosmicpower(), new Teleport(), new Confusion(), new Hypnosis() },
			[7] = new List<Move>() { new Nightshade() },
			[14] = new List<Move>() { new Confuseray() },
			[21] = new List<Move>() { new Airslash() },
			[28] = new List<Move>() { new Shadowball() },
			[35] = new List<Move>() { new Moonlight() },
			[42] = new List<Move>() { new Nightdaze() },
			[49] = new List<Move>() { new Magiccoat() },
			[56] = new List<Move>() { new Moonblast() },
			[63] = new List<Move>() { new Phantomforce() },
			[70] = new List<Move>() { new Dreameater() },
			[77] = new List<Move>() { new Wideguard() },
			[84] = new List<Move>() { new Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Agility(), new Airslash(), new Blizzard(), new Calmmind(), new Cosmicpower(), new Dazzlinggleam(), new Dualwingbeat(), new Endure(), new Expandingforce(), new Facade(), new Fly(), new Focusblast(), new Futuresight(), new Gigaimpact(), new Heatwave(), new Helpinghand(), new Hex(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icywind(), new Lightscreen(), new Magicroom(), new Meteorbeam(), new Phantomforce(), new Poltergeist(), new Protect(), new Psychic(), new Psychocut(), new Psyshock(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Scaryface(), new Shadowball(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Trick(), new Trickroom(), new Willowisp(), new Wonderroom(), new Workup() };
		public override int Weight => 1200;
		public override int ExpYield => 340;
		public override int CatchRate => 45;
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