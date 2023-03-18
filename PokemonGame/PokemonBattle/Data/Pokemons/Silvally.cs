using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Silvally : Pokemon
	{
		public override string Name => "Silvally";
		public override List<Ability> AvailableAbilities => new() {new Rkssystem() };
		public override Stats BaseStats => new Stats(95, 95, 95, 95, 95, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Multiattack() },
			[1] = new List<Move>() { new Multiattack(), new Explosion(), new Thunderfang(), new Icefang(), new Firefang(), new Poisonfang(), new Imprison(), new Ironhead(), new Tackle(), new Bite(), new Aerialace(), new Scaryface() },
			[15] = new List<Move>() { new Doublehit() },
			[20] = new List<Move>() { new Metalsound() },
			[25] = new List<Move>() { new Crushclaw() },
			[30] = new List<Move>() { new Airslash() },
			[35] = new List<Move>() { new Triattack() },
			[40] = new List<Move>() { new Xscissor() },
			[45] = new List<Move>() { new Crunch() },
			[50] = new List<Move>() { new Takedown() },
			[55] = new List<Move>() { new Doubleedge() },
			[60] = new List<Move>() { new Partingshot() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Airslash(), new Crunch(), new Dracometeor(), new Dragonclaw(), new Endure(), new Facade(), new Firefang(), new Flamethrower(), new Flashcannon(), new Gigaimpact(), new Grasspledge(), new Hail(), new Heatwave(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icefang(), new Icywind(), new Imprison(), new Irondefense(), new Ironhead(), new Outrage(), new Payback(), new Protect(), new Psychicfangs(), new Raindance(), new Rest(), new Reversal(), new Rockslide(), new Round(), new Sandstorm(), new Scaryface(), new Selfdestruct(), new Shadowball(), new Shadowclaw(), new Sleeptalk(), new Snarl(), new Snore(), new Steelbeam(), new Steelwing(), new Substitute(), new Sunnyday(), new Surf(), new Swift(), new Swordsdance(), new Terrainpulse(), new Thunderbolt(), new Thunderfang(), new Thunderwave(), new Triattack(), new Uturn(), new Workup(), new Xscissor(), new Zenheadbutt() };
		public override int Weight => 1005;
		public override int ExpYield => 285;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 3,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}