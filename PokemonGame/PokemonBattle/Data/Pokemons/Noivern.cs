using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Noivern : Pokemon
	{
		public override string Name => "Noivern";
		public override List<Ability> AvailableAbilities => new() {new Frisk(), new Infiltrator() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Telepathy() };
		public override Stats BaseStats => new Stats(85, 70, 80, 97, 80, 123);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Flying, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Dragonpulse() },
			[1] = new List<Move>() { new Dragonpulse(), new Moonlight(), new Absorb(), new Tackle(), new Gust(), new Supersonic() },
			[12] = new List<Move>() { new Doubleteam() },
			[16] = new List<Move>() { new Wingattack() },
			[20] = new List<Move>() { new Bite() },
			[24] = new List<Move>() { new Aircutter() },
			[28] = new List<Move>() { new Whirlwind() },
			[32] = new List<Move>() { new Superfang() },
			[36] = new List<Move>() { new Airslash() },
			[40] = new List<Move>() { new Screech() },
			[44] = new List<Move>() { new Roost() },
			[51] = new List<Move>() { new Tailwind() },
			[56] = new List<Move>() { new Hurricane() },
			[62] = new List<Move>() { new Boomburst() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Agility(), new Airslash(), new Attract(), new Brickbreak(), new Darkpulse(), new Dracometeor(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Dualwingbeat(), new Endure(), new Facade(), new Flamethrower(), new Fly(), new Focusblast(), new Gigaimpact(), new Heatwave(), new Hiddenpower(), new Hurricane(), new Hyperbeam(), new Hypervoice(), new Irontail(), new Leechlife(), new Outrage(), new Protect(), new Psychic(), new Rest(), new Round(), new Screech(), new Shadowball(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Solarbeam(), new Steelwing(), new Substitute(), new Sunnyday(), new Swift(), new Taunt(), new Thief(), new Uproar(), new Uturn(), new Wildcharge(), new Xscissor() };
		public override int Weight => 850;
		public override int ExpYield => 187;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}