using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Espeon : Pokemon
	{
		public override string Name => "Espeon";
		public override List<Ability> AvailableAbilities => new() {new Synchronize() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Magicbounce() };
		public override Stats BaseStats => new Stats(65, 65, 60, 130, 95, 110);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Confusion() },
			[1] = new List<Move>() { new Confusion(), new Covet(), new Bite(), new Copycat(), new Batonpass(), new Takedown(), new Charm(), new Doubleedge(), new Helpinghand(), new Tackle(), new Growl(), new Tailwhip() },
			[5] = new List<Move>() { new Sandattack() },
			[10] = new List<Move>() { new Quickattack() },
			[15] = new List<Move>() { new Babydolleyes() },
			[20] = new List<Move>() { new Swift() },
			[25] = new List<Move>() { new Psybeam() },
			[30] = new List<Move>() { new Morningsun() },
			[35] = new List<Move>() { new Powerswap() },
			[40] = new List<Move>() { new Psychic() },
			[45] = new List<Move>() { new Psychup() },
			[50] = new List<Move>() { new Futuresight() },
			[55] = new List<Move>() { new Lastresort() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Batonpass(), new Bodyslam(), new Calmmind(), new Charm(), new Cut(), new Dazzlinggleam(), new Dig(), new Doubleteam(), new Dreameater(), new Endure(), new Expandingforce(), new Facade(), new Faketears(), new Flash(), new Focusenergy(), new Futuresight(), new Gigaimpact(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Irontail(), new Lightscreen(), new Magicroom(), new Payday(), new Powerswap(), new Protect(), new Psychic(), new Psychicfangs(), new Psychup(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Retaliate(), new Round(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Storedpower(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Trick(), new Trickroom(), new Weatherball(), new Workup(), new Zenheadbutt() };
		public override int Weight => 265;
		public override int ExpYield => 184;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}