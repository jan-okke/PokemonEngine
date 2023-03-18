using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Spoink : Pokemon
	{
		public override string Name => "Spoink";
		public override List<Ability> AvailableAbilities => new() {new Thickfat(), new Owntempo() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Gluttony() };
		public override Stats BaseStats => new Stats(60, 25, 35, 70, 80, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Splash() },
			[7] = new List<Move>() { new Confusion() },
			[10] = new List<Move>() { new Growl() },
			[14] = new List<Move>() { new Psybeam() },
			[15] = new List<Move>() { new Psychup() },
			[18] = new List<Move>() { new Confuseray() },
			[21] = new List<Move>() { new Magiccoat() },
			[26] = new List<Move>() { new Zenheadbutt() },
			[29] = new List<Move>() { new Powergem(), new Rest() },
			[33] = new List<Move>() { new Snore() },
			[38] = new List<Move>() { new Psyshock() },
			[40] = new List<Move>() { new Payback() },
			[44] = new List<Move>() { new Psychic() },
			[50] = new List<Move>() { new Bounce() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Bounce(), new Calmmind(), new Chargebeam(), new Confide(), new Covet(), new Doubleteam(), new Dreameater(), new Endure(), new Facade(), new Flash(), new Frustration(), new Grassknot(), new Healbell(), new Hiddenpower(), new Icywind(), new Irontail(), new Lightscreen(), new Magiccoat(), new Payback(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Return(), new Roleplay(), new Round(), new Shadowball(), new Shockwave(), new Signalbeam(), new Skillswap(), new Sleeptalk(), new Snatch(), new Snore(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Telekinesis(), new Thief(), new Thunderwave(), new Torment(), new Trick(), new Trickroom(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Amnesia(), new Extrasensory(), new Futuresight(), new Mirrorcoat(), new Simplebeam(), new Trick(), new Whirlwind(), new Zenheadbutt() };
		public override int Weight => 306;
		public override int ExpYield => 66;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}